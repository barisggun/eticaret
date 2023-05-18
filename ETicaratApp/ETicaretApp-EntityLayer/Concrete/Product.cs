using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        public bool? Status { get; set; }
        public string? ProductImage { get; set; }
        public Category? Category { get; set; }
    }
}
