using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.ContactModule
{
    public class ContactAllQuery : IRequest<List<Contact>>
    {
        public class ContactsAllQueryHandler : IRequestHandler<ContactAllQuery, List<Contact>>
        {
            private readonly AppDbContext db;

            public ContactsAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Contact>> Handle(ContactAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Contacts
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
