using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PersonModule
{
    public class PersonSingleQuery : IRequest<Person>
    {
        public int Id { get; set; }


        public class PersonSingleQueryHandler : IRequestHandler<PersonSingleQuery, Person>
        {
            private readonly AppDbContext db;

            public PersonSingleQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Person> Handle(PersonSingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.People
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
