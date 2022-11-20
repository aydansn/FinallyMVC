using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BlogModule
{
    public class BlogSingleQuery : IRequest<Blog>
    {
        public int Id { get; set; }


        public class BlogSingleQueryHandler : IRequestHandler<BlogSingleQuery, Blog>
        {
            private readonly AppDbContext db;

            public BlogSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Blog> Handle(BlogSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Blogs
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
