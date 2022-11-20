using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ExperienceModule
{
    public class ExperienceSingleQuery : IRequest<Experience>
    {

        public int Id { get; set; }


        public class ExperienceSingleQueryHandler : IRequestHandler<ExperienceSingleQuery, Experience>
        {
            private readonly AppDbContext db;

            public ExperienceSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Experience> Handle(ExperienceSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Experiences
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
