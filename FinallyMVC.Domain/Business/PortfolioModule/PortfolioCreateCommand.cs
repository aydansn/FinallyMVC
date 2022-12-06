using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PortfolioModule
{
    public class PortfolioCreateCommand : IRequest<Portfolio>
    {
        public string Name { get; set; }

        public string Link { get; set; }
        
        public IFormFile Image { get; set; }



        public class PortfolioCreateCommandHandler : IRequestHandler<PortfolioCreateCommand, Portfolio>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public PortfolioCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Portfolio> Handle(PortfolioCreateCommand request, CancellationToken cancellationToken)
            {
                var Portfolio = new Portfolio()
                {

                    Name = request.Name,
                    Link = request.Link
                };

                Portfolio.ImageURL = request.Image.GetRandomImagePath("Portfolio");
                await env.SaveAsync(request.Image, Portfolio.ImageURL, cancellationToken);
                await db.Portfolios.AddAsync(Portfolio, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Portfolio;
            }
        }
    }
}
