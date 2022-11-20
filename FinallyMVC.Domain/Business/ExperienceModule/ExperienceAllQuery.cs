using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ExperienceModule
{
    public class ExperienceAllQuery : IRequest<List<Experience>>
    {
        public class ExperiencesAllQueryHandler : IRequestHandler<ExperienceAllQuery, List<Experience>>
        {
            private readonly AppDbContext db;

            public ExperiencesAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Experience>> Handle(ExperienceAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Experiences
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
