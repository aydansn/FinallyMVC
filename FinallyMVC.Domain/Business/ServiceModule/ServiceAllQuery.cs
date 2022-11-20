using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ServiceModule
{
    public class ServiceAllQuery :IRequest<List<Service>>
    {
        public class ServiceAllQueryHandler : IRequestHandler<ServiceAllQuery, List<Service>>
        {
            private readonly AppDbContext db;

            public ServiceAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Service>> Handle(ServiceAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Serviceses
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
