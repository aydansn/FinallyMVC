using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ContactModule
{
    public class ContactSingleQuery : IRequest<Contact>
    {
        public int Id { get; set; }


        public class ContactSingleQueryHandler : IRequestHandler<ContactSingleQuery, Contact>
        {
            private readonly AppDbContext db;

            public ContactSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Contact> Handle(ContactSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Contacts
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
