using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.BlogModule
{
    public class BlogCreateCommand : IRequest<Blog>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }

        public class BlogCreateCommandHandler : IRequestHandler<BlogCreateCommand, Blog>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public BlogCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Blog> Handle(BlogCreateCommand request, CancellationToken cancellationToken)
            {
                var Blog = new Blog()
                {
                    Title = request.Title,
                    Body = request.Body,
                    PublishDate = DateTime.UtcNow.AddHours(4)
                };
                Blog.ImageURL = request.Image.GetRandomImagePath("blog");
                await env.SaveAsync(request.Image, Blog.ImageURL, cancellationToken);
                await db.Blogs.AddAsync(Blog, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Blog;
            }
        }
    }
}
