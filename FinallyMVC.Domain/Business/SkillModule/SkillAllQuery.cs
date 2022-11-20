using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.SkillModule
{
    public class SkillAllQuery :IRequest<List<Skill>>
    {
        public class SkillsAllQueryHandler : IRequestHandler<SkillAllQuery, List<Skill>>
        {
            private readonly AppDbContext db;

            public SkillsAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Skill>> Handle(SkillAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Skills
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
