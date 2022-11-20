using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ServiceModule
{
    public class ServiceSingleQuery : IRequest<Service>
    {
        public int Id { get; set; }


        public class ServiceSingleQueryHandler : IRequestHandler<ServiceSingleQuery, Service>
        {
            private readonly AppDbContext db;

            public ServiceSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Service> Handle(ServiceSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Serviceses
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
