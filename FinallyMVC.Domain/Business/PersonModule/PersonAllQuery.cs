using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PersonModule
{
    public class PersonAllQuery :IRequest<List<Person>>
    {
        public class PersonsAllQueryHandler : IRequestHandler<PersonAllQuery, List<Person>>
        {
            private readonly AppDbContext db;

            public PersonsAllQueryHandler(AppDbContext db)

            {
                this.db = db;
            }
            public async Task<List<Person>> Handle(PersonAllQuery request, CancellationToken cancellationToken)
            {

                var data = await db.People
                 .Where(m => m.DeletedDate == null)
                 .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
