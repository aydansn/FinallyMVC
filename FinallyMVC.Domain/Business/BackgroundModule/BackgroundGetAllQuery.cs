using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BackgroundModule
{
    public class BackgroundGetAllQuery : IRequest<List<Background>>
    {
        public class BackgroundsAllQueryHandler : IRequestHandler<BackgroundGetAllQuery, List<Background>>
        {
            private readonly AppDbContext db;

            public BackgroundsAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Background>> Handle(BackgroundGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Backgrounds
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
