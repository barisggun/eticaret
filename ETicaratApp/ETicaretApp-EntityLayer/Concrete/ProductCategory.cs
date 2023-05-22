using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class ProductCategory:BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }  

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
