﻿using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Background : BaseEntity
    {
        public DateTime? Date { get; set; }
        
        public string Title { get; set; }

        public string Body { get; set; }
    }
}