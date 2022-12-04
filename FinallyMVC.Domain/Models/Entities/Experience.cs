using FinallyMVC.Domain.AppCode.Infrastructure;
using FinallyMVC.Domain.Business.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Experience : BaseEntity
    {
        public DateTime? Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
        public string ImageURL { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

        public ExperienceType ExperienceType { get; set; }

    }
}
