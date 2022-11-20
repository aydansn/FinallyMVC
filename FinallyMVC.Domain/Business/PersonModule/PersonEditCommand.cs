using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PersonModule
{
    public class PersonEditCommand : IRequest<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string Careerlevel { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string WebSite { get; set; }

        public class PersonEditCommandHandler : IRequestHandler<PersonEditCommand, Person>
        {
            private readonly AppDbContext db;

            public PersonEditCommandHandler(AppDbContext db)
            {
                this.db = db;
            }
            public async Task<Person> Handle(PersonEditCommand request, CancellationToken cancellationToken)
            {
                var Person = await db.People.FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (Person == null)
                {
                    return null;
                }

                Person.Id = request.Id;
                Person.Name = request.Name;
                Person.Age = request.Age;
                Person.Location = request.Location;
                Person.Degree = request.Degree;
                Person.Careerlevel = request.Careerlevel;
                Person.Fax = request.Fax;
                Person.EMail = request.EMail;
                Person.WebSite = request.WebSite;

                await db.SaveChangesAsync(cancellationToken);

                return Person;
            }
        }
    }
}
