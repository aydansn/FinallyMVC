using FinallyMVC.Domain.AppCode.Infrastructure;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string Careerlevel { get; set; }
        public string  Phone { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string WebSite { get; set; }
    }
}
