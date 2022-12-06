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
    public class Portfolio : BaseEntity
    {
        public string Name { get; set; }
       
        public string Link { get; set; }
        public string ImageURL { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
