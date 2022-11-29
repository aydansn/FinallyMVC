using AutoMapper;
using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ServiceModule
{
    public class ServiceCreateCommand : IRequest<Service>
    {
        public IFormFile ImageURL { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public class ServiceCreateCommandHandler : IRequestHandler<ServiceCreateCommand, Service>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public ServiceCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Service> Handle(ServiceCreateCommand request, CancellationToken cancellationToken)
            {
                var Service = new Service()
                {
                   
                    Title = request.Title,
                    Body = request.Body
                };
                Service.ImageURL = request.ImageURL.GetRandomImagePath("service");
                await env.SaveAsync(request.ImageURL, Service.ImageURL, cancellationToken);
                await db.Serviceses.AddAsync(Service, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);
                return Service;
            }
        }
    }
}
