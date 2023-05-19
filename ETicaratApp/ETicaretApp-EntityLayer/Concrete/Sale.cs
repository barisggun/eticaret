﻿using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Sale:BaseEntity
    {
        public DateTime? SaleDate { get; set; }
        public ICollection<Product>? Products { get; set; }
        public Customer? Customer { get; set; }
    }
}
