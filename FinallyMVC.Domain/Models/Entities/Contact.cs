using FinallyMVC.Domain.AppCode.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Contact : BaseEntity
    {

        public string ImageURL { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
