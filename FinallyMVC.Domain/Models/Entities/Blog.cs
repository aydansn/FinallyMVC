using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageURL { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
