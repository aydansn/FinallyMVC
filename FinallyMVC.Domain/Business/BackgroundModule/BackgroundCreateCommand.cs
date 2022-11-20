using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BackgroundModule
{
    public class BackgroundCreateCommand :IRequest<Background>
    {
       
        public string Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }

        public class BackgroundCreateCommandHandler : IRequestHandler<BackgroundCreateCommand, Background>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public BackgroundCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Background> Handle(BackgroundCreateCommand request, CancellationToken cancellationToken)
            {
                var Background = new Background();

                Background.Date = request.Date;
                Background.Place = request.Place;
                Background.Body = request.Body;
                Background.Profession = request.Profession;



                string physicalPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads");



                await db.Backgrounds.AddAsync(Background, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);


                return Background;

            }
        }
    }
}
