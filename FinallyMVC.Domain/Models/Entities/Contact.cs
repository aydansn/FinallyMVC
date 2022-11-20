using FinallyMVC.Domain.AppCode.Infrastructure;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Contact : BaseEntity
    {
        public string ImageURL { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
