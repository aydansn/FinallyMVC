using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.SkillModule
{
    public class SkillEditCommand : IRequest<Skill>
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string job { get; set; }
        public string WorkPlace { get; set; }

        public class SkillEditCommandHandler : IRequestHandler<SkillEditCommand, Skill>
        {
            private readonly AppDbContext db;

            public SkillEditCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Skill> Handle(SkillEditCommand request, CancellationToken cancellationToken)
            {
                var Skill = await db.Skills.FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (Skill == null)
                {
                    return null;
                }

                Skill.Id = request.Id;
                Skill.Body = request.Body;
                Skill.job = request.job;
                Skill.WorkPlace = request.WorkPlace;

                await db.SaveChangesAsync(cancellationToken);

                return Skill;
            }
        }
    }
}
