﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SearchFilters
{
    public class ProductFilter
    {
        public bool IsActive { get; set; }
        public DateTime InsertDateFrom { get; set; }
        public DateTime InsertDateTo { get; set; }
        
    }
}
