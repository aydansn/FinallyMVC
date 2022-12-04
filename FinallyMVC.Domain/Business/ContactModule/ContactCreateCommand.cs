using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ContactModule
{
    public class ContactCreateCommand : IRequest<Contact>
    {

        public IFormFile ImageURL { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public class ContactCreateCommandHandler : IRequestHandler<ContactCreateCommand, Contact>
        {
            private readonly AppDbContext db;
            private readonly IHostEnvironment env;

            public ContactCreateCommandHandler(AppDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<Contact> Handle(ContactCreateCommand request, CancellationToken cancellationToken)
            {
                var Contact = new Contact()
                {
                    Phone = request.Phone,
                    Title = request.Title,
                    Body = request.Body
                };

                Contact.ImageURL = request.ImageURL.GetRandomImagePath("contact");
                await env.SaveAsync(request.ImageURL, Contact.ImageURL, cancellationToken);
                await db.Contacts.AddAsync(Contact, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Contact;
            }
        }
    }
}
