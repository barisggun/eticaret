using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class Category:BaseEntity
    {
        public string? CategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
