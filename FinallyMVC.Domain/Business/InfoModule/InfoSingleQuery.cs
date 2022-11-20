using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.InfoModule
{
    public class InfoSingleQuery : IRequest<Info>
    {
        public int Id { get; set; }
        public class InfoSingleQueryHandler : IRequestHandler<InfoSingleQuery, Info>
        {
            private readonly AppDbContext db;

            public InfoSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Info> Handle(InfoSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Infos
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
