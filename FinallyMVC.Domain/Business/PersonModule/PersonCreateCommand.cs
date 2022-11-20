using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.PersonModule
{
    public class PersonCreateCommand : IRequest<Person>
    {
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

        public class PersonCreateCommandHandler : IRequestHandler<PersonCreateCommand, Person>
        {
            private readonly AppDbContext db;

            public PersonCreateCommandHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<Person> Handle(PersonCreateCommand request, CancellationToken cancellationToken)
            {
                var Person = new Person()
                {
                    Name = request.Name,
                    Age = request.Age,
                    Location = request.Location,
                    Experience = request.Experience,
                    Degree = request.Degree,
                    Careerlevel = request.Careerlevel,
                    Phone = request.Phone,
                    Fax = request.Fax,
                    WebSite = request.WebSite
                };

                await db.People.AddAsync(Person, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return Person;
            }
        }
    }
}
