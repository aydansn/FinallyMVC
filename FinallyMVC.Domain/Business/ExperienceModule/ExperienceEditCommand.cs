using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ExperienceModule
{
    public class ExperienceEditCommand : IRequest<Experience>
    {
        public int Id { get; set; }
        public string ImageURl { get; set; }
        public class ExperienceEditCommandHandler : IRequestHandler<ExperienceEditCommand, Experience>
        {
            private readonly AppDbContext db;

            public ExperienceEditCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Experience> Handle(ExperienceEditCommand request, CancellationToken cancellationToken)
            {
                var Experience = await db.Experiences.FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (Experience == null)
                {
                    return null;
                }

                Experience.Id = request.Id;
                Experience.ImageURL = request.ImageURl;

                await db.SaveChangesAsync(cancellationToken);

                return Experience;
            }
        }
    }
}
