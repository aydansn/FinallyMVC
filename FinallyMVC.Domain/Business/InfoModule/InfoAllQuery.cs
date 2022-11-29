using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.InfoModule
{
    public class InfoAllQuery :IRequest<List<Info>>
    {
        public class InfoAllQueryHandler : IRequestHandler<InfoAllQuery, List<Info>>
        {
            private readonly AppDbContext db;

            public InfoAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Info>> Handle(InfoAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Infos
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
