using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Skill: BaseEntity
    {
        public string Body { get; set; }
        public string job { get; set; }
        public string WorkPlace { get; set; }
    }
}
