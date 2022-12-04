using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ExperienceModule
{
    public class ExperienceCreateCommand : IRequest<Experience>
    {
        public IFormFile ImageURL { get; set; }
        public DateTime? Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
        public class ExperienceCreateCommandHandler : IRequestHandler<ExperienceCreateCommand, Experience>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public ExperienceCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Experience> Handle(ExperienceCreateCommand request, CancellationToken cancellationToken)
            {
                var Experience = new Experience()
                {

                   Date = DateTime.UtcNow.AddHours(4),
                   Place = request.Place,
                   Body = request.Body,
                   Profession = request.Profession
            };

                Experience.ImageURL = request.ImageURL.GetRandomImagePath("experience");
                await env.SaveAsync(request.ImageURL, Experience.ImageURL, cancellationToken);
                await db.Experiences.AddAsync(Experience, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Experience;
            }
        }
    }
}
