using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Business.InfoModule;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.InfoModule
{
    public class InfoEditCommand : IRequest<Info>
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }

        public IFormFile Image { get; set; }
        public string Phone { get; set; }
        public string Body { get; set; }

        public class InfoEditCommandHandler : IRequestHandler<InfoEditCommand, Info>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public InfoEditCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Info> Handle(InfoEditCommand request, CancellationToken cancellationToken)
            {
                var model = await db.Infos
                    .FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (model == null)
                {
                    return null;
                }
                model.Id = request.Id;
                model.Phone = request.Phone;
                model.Body = request.Body;

                if (request.Image == null)
                    goto save;

                string newImageName = request.Image.GetRandomImagePath("Info");

                await env.SaveAsync(request.Image, newImageName, cancellationToken);

                env.ArchiveImage(model.ImageURL);

                model.ImageURL = newImageName;

            save:
                await db.SaveChangesAsync(cancellationToken);

                return model;
            }
        }
    }
}
