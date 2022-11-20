using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ContactModule
{
    public class ContactEditCommand : IRequest<Contact>
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public IFormFile Image { get; set; }

        public string Phone { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public class ContactEditCommandHandler : IRequestHandler<ContactEditCommand, Contact>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public ContactEditCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Contact> Handle(ContactEditCommand request, CancellationToken cancellationToken)
            {
                var model = await db.Contacts
                    .FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (model == null)
                {
                    return null;
                }
                model.Id = request.Id;
                model.Phone = request.Phone;
                model.Title = request.Title;
                model.Body = request.Body;

                if (request.Image == null)
                    goto save;

                string newImageName = request.Image.GetRandomImagePath("contact");

                await env.SaveAsync(request.Image, newImageName, cancellationToken);

                env.ArchiveImage(model.ImageURL);

                model.ImageURL = newImageName;

                     save:
                await db.SaveChangesAsync(cancellationToken);

                return model;
            }
        }
    }
}
