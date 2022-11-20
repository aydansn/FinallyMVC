using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ServiceModule
{
    public class ServiceCreateCommand : IRequest<Service>
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public class ServiceCreateCommandHandler : IRequestHandler<ServiceCreateCommand, Service>
        {
            private readonly AppDbContext db;

            public ServiceCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Service> Handle(ServiceCreateCommand request, CancellationToken cancellationToken)
            {
                var Service = new Service()
                {
                   
                    ImageURL = request.ImageURL,
                    Title = request.Title,
                    Body = request.Body
                };

                await db.Serviceses.AddAsync(Service, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Service;
            }
        }
    }
}
