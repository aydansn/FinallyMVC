using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Background : BaseEntity
    {
        public string Date { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
    }
}
