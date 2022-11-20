using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BlogModule
{
    public class BlogEditCommand : IRequest<Blog>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageURl { get; set; }
        public DateTime? PublishDate { get; set; }

        public class BlogEditCommandHandler : IRequestHandler<BlogEditCommand, Blog>
        {
            private readonly AppDbContext db;

            public BlogEditCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Blog> Handle(BlogEditCommand request, CancellationToken cancellationToken)
            {
                var Blog = await db.Blogs.FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (Blog == null)
                {
                    return null;
                }

                Blog.Id = request.Id;
                Blog.Title = request.Title;
                Blog.Body = request.Body;
                Blog.ImageURL = request.ImageURl;
                Blog.PublishDate = request.PublishDate;

                await db.SaveChangesAsync(cancellationToken);

                return Blog;
            }
        }
    }
}
