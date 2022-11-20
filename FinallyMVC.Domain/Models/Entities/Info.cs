using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Info: BaseEntity
    {
        public string ImageURL { get; set; }
        public string Phone { get; set; }
        public string Body { get; set; }
    }
}
