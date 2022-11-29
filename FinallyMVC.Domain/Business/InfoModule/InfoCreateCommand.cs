using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.InfoModule
{
    public class InfoCreateCommand : IRequest<Info>
    {
        public IFormFile ImageURL { get; set; }
        public string Phone { get; set; }
        public string Body { get; set; }

        public class InfoCreateCommandHandler : IRequestHandler<InfoCreateCommand, Info>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public InfoCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Info> Handle(InfoCreateCommand request, CancellationToken cancellationToken)
            {
                var Info = new Info()
                {
                   
                    Phone = request.Phone,
                    Body = request.Body
                };

                Info.ImageURL = request.ImageURL.GetRandomImagePath("info");
                await env.SaveAsync(request.ImageURL, Info.ImageURL, cancellationToken);
                await db.Infos.AddAsync(Info, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Info;
            }
        }
    }
}
