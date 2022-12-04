﻿using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Subscribe : BaseEntity
    {
        public string Email { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
