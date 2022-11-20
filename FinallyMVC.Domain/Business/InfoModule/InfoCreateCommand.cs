using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.InfoModule
{
    public class InfoCreateCommand : IRequest<Info>
    {
        public string ImageURL { get; set; }
        public string Phone { get; set; }
        public string Body { get; set; }

        public class InfoCreateCommandHandler : IRequestHandler<InfoCreateCommand, Info>
        {
            private readonly AppDbContext db;

            public InfoCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Info> Handle(InfoCreateCommand request, CancellationToken cancellationToken)
            {
                var Info = new Info()
                {
                    ImageURL = request.ImageURL,
                    Phone = request.Phone,
                    Body = request.Body
                };

                await db.Infos.AddAsync(Info, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Info;
            }
        }
    }
}
