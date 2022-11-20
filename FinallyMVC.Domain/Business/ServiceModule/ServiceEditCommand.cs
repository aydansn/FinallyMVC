using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Business.ServiceModule;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ServiceModule
{
    public class ServiceEditCommand : IRequest<Service>
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public IFormFile Image { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public class ServiceEditCommandHandler : IRequestHandler<ServiceEditCommand, Service>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public ServiceEditCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Service> Handle(ServiceEditCommand request, CancellationToken cancellationToken)
            {
                var model = await db.Serviceses
                    .FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (model == null)
                {
                    return null;
                }
                model.Id = request.Id;
                model.Body = request.Body;

                if (request.Image == null)
                    goto save;

                string newImageName = request.Image.GetRandomImagePath("Service");

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
