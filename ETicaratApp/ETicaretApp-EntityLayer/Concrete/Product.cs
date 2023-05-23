﻿using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
