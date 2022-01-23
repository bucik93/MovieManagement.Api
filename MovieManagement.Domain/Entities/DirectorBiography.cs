﻿using MovieManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class DirectorBiography : AuditableEntity
    {
        public DateTime DoB { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}