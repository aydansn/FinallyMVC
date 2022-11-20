using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BackgroundModule
{
  

    public class BackgroundEditCommand : IRequest<Background>
    {
        public string Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
        public int Id { get; set; }

        public class BackgroundEditCommandHandler : IRequestHandler<BackgroundEditCommand, Background>
        {
            private readonly AppDbContext db;

            public BackgroundEditCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Background> Handle(BackgroundEditCommand request, CancellationToken cancellationToken)
            {
                var Background = await db.Backgrounds.FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (Background == null)
                {
                    return null;
                }

                Background.Date = request.Date;
                Background.Place = request.Place;
                Background.Body = request.Body;
                Background.Profession = request.Profession;
                Background.Id = request.Id;

                await db.SaveChangesAsync(cancellationToken);

                return Background;
            }
        }
    }
}
