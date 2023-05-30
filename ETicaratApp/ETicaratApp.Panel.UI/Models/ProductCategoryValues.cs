using ETicaretApp_EntityLayer.Concrete;

namespace ETicaratApp.Panel.UI.Models
{
    public class ProductCategoryValues
    {
        public Category Category { get; set; }
        public CategoryProperties CategoryProperties { get; set; }
        public Product Product { get; set; }
        public PropertyValue PropertyValue { get; set; }

    }
}
