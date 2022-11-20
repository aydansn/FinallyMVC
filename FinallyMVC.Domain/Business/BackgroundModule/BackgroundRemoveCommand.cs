using FinallyMVC.Domain.AppCode.Infrastructure;
using FinallyMVC.Domain.Models.DataContexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BackgroundModule
{
    public class BackgroundRemoveCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }


        public class BackgroundRemoveCommandHandler : IRequestHandler<BackgroundRemoveCommand, JsonResponse>
        {
            private readonly AppDbContext db;

            public BackgroundRemoveCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<JsonResponse> Handle(BackgroundRemoveCommand request, CancellationToken cancellationToken)
            {
                var entity = db.Backgrounds
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
