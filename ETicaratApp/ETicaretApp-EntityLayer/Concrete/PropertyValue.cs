using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class PropertyValue : BaseEntity
    {
        public int CategoryPropertyId { get; set; }
        public CategoryProperties CategoryProperty { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
    }
}
