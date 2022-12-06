using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Business.PortfolioModule;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PortfolioModule
{
    public class PortfolioEditCommand : IRequest<Portfolio>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
       
        public IFormFile Image { get; set; }

        public  int? CategoryId { get; set; }
        public class PortfolioEditCommandHandler : IRequestHandler<PortfolioEditCommand, Portfolio>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public PortfolioEditCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Portfolio> Handle(PortfolioEditCommand request, CancellationToken cancellationToken)
            {
                var model = await db.Portfolios
                    .FirstOrDefaultAsync(b => b.Id == request.Id

                && b.DeletedDate == null, cancellationToken);

                if (model == null)
                {
                    return null;
                }
                model.Id = request.Id;
                model.Name = request.Name;
                model.Link = request.Link;

                if (request.Image == null)
                    goto save;

                string newImageName = request.Image.GetRandomImagePath("Portfolio");

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
