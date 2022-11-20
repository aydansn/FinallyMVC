using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BlogModule
{
    public class BlogAllQuery :IRequest<List<Blog>>
    {
        public class BlogsAllQueryHandler : IRequestHandler<BlogAllQuery, List<Blog>>
        {
            private readonly AppDbContext db;

            public BlogsAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Blog>> Handle(BlogAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Blogs
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
