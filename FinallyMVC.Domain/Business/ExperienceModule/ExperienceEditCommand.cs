using FinallyMVC.Domain.Business.Enums;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ExperienceModule
{
    public class ExperienceEditCommand : IRequest<Experience>
    {
        public int Id { get; set; }
        public IFormFile ImageURL { get; set; }

        public DateTime? Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
        public ExperienceType ExperienceType { get; set; }

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
                Experience.Place = request.Place;
                Experience.Body = request.Body;
                Experience.Profession = request.Profession;
                Experience.ExperienceType = request.ExperienceType;
                Experience.Date = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);

                return Experience;
            }
        }
    }
}
