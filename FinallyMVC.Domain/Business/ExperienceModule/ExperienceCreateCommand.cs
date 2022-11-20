using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ExperienceModule
{
    public class ExperienceCreateCommand : IRequest<Experience>
    {
        public string ImageURL { get; set; }

        public class ExperienceCreateCommandHandler : IRequestHandler<ExperienceCreateCommand, Experience>
        {
            private readonly AppDbContext db;

            public ExperienceCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Experience> Handle(ExperienceCreateCommand request, CancellationToken cancellationToken)
            {
                var Experience = new Experience()
                {
                    ImageURL = request.ImageURL
                };

                await db.Experiences.AddAsync(Experience, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Experience;
            }
        }
    }
}
