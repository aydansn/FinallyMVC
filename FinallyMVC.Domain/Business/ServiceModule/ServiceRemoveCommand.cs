using FinallyMVC.Domain.AppCode.Infrastructure;
using FinallyMVC.Domain.Models.DataContexts;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ServiceModule
{
    public class ServiceRemoveCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }

        public class ServiceRemoveCommandHandler : IRequestHandler<ServiceRemoveCommand, JsonResponse>
        {
            private readonly AppDbContext db;

            public ServiceRemoveCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<JsonResponse> Handle(ServiceRemoveCommand request, CancellationToken cancellationToken)
            {
                var entity = db.Serviceses
                   .FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);


                if (entity == null)
                {
                    return new JsonResponse
                    {
                        Error = true,
                        Message = "Qeyd tapilmadi"
                    };
                }

                entity.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };
            }
        }
    }
}
