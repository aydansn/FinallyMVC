using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ContactModule
{
    public class ContactCreateCommand : IRequest<Contact>
    {

        public string ImageURL { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public class ContactCreateCommandHandler : IRequestHandler<ContactCreateCommand, Contact>
        {
            private readonly AppDbContext db;

            public ContactCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Contact> Handle(ContactCreateCommand request, CancellationToken cancellationToken)
            {
                var Contact = new Contact()
                {
                    ImageURL = request.ImageURL,
                    Phone = request.Phone,
                    Title = request.Title,
                    Body = request.Body
                };

                await db.Contacts.AddAsync(Contact, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Contact;
            }
        }
    }
}
