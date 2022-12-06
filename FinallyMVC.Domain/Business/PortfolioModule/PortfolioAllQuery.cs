using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PortfolioModule
{
    public class PortfolioAllQuery :IRequest<List<Portfolio>>
    {
        public class PortfolioAllQueryHandler : IRequestHandler<PortfolioAllQuery, List<Portfolio>>
        {
            private readonly AppDbContext db;

            public PortfolioAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Portfolio>> Handle(PortfolioAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Portfolios
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
