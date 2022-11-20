using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BlogModule
{
    public class BlogCreateCommand : IRequest<Blog>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageURL { get; set; }
        public DateTime? PublishDate { get; set; }

        public class BlogCreateCommandHandler : IRequestHandler<BlogCreateCommand, Blog>
        {
            private readonly AppDbContext db;

            public BlogCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Blog> Handle(BlogCreateCommand request, CancellationToken cancellationToken)
            {
                var Blog = new Blog()
                {
                    Title = request.Title,
                    Body = request.Body, 
                    ImageURL = request.ImageURL,
                    PublishDate= request.PublishDate
                };

                await db.Blogs.AddAsync(Blog, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Blog;
            }
        }
    }
}
