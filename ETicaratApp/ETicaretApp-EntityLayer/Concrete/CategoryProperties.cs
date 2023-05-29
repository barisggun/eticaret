using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_EntityLayer.Concrete
{
    public class CategoryProperties : BaseEntity
    {
        public int CategeoryId { get; set; }
        public Category Category { get; set; }
        public string PropertyName { get; set; }

        //public List<PropertyValue> PropertyValues { get; set;}
    }
}
