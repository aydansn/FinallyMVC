using FinallyMVC.Domain.AppCode.Infrastructure;
using System;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image{ get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
