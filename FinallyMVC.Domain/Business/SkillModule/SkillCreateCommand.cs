using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.SkillModule
{
    public class SkillCreateCommand : IRequest<Skill>
    {
        public string Body { get; set; }
        public string job { get; set; }
        public string WorkPlace { get; set; }

        public class SkillCreateCommandHandler : IRequestHandler<SkillCreateCommand, Skill>
        {
            private readonly AppDbContext db;

            public SkillCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Skill> Handle(SkillCreateCommand request, CancellationToken cancellationToken)
            {
                var Skill = new Skill()
                {
                    
                    Body = request.Body, 
                    job = request.job,
                    WorkPlace= request.WorkPlace
                };

                await db.Skills.AddAsync(Skill, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Skill;
            }
        }
    }
}
