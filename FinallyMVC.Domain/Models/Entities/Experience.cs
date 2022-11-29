using FinallyMVC.Domain.AppCode.Infrastructure;
using FinallyMVC.Domain.Business.Enums;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Experience : BaseEntity
    {
        public string Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
        public string ImageURL { get; set; }

        public ExperienceType ExperienceType { get; set; }

    }
}
