using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BackgroundModule
{
    public class BackgroundSingleQuery : IRequest<Background>
    {
        public int Id { get; set; }
        

        public class BackgroundSingleQueryHandler : IRequestHandler<BackgroundSingleQuery, Background>
        {
            private readonly AppDbContext db;

            public BackgroundSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Background> Handle(BackgroundSingleQuery request, CancellationToken cancellationToken)
            {

                var entity = await db.Backgrounds
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;

            }
        }


    }
}
