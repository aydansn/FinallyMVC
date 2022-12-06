using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PortfolioModule
{
    public class PortfolioSingleQuery : IRequest<Portfolio>
    {
        public int Id { get; set; }
        public class PortfolioSingleQueryHandler : IRequestHandler<PortfolioSingleQuery, Portfolio>
        {
            private readonly AppDbContext db;

            public PortfolioSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Portfolio> Handle(PortfolioSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Portfolios
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);
                return entity;
            }
        }
    }
}
