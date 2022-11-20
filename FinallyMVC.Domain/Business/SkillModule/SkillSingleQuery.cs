using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.SkillModule
{
    public class SkillSingleQuery : IRequest<Skill>
    {
        public int Id { get; set; }


        public class SkillSingleQueryHandler : IRequestHandler<SkillSingleQuery, Skill>
        {
            private readonly AppDbContext db;

            public SkillSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Skill> Handle(SkillSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Skills
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
