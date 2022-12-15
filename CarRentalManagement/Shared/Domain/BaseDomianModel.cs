﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public abstract class BaseDomianModel
    {
        public int Id { get;set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdateBy { get; set; }
    }
}
