using FinallyMVC.Domain.AppCode.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public IFormFile Image { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
