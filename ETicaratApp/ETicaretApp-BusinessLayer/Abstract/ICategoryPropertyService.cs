using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_BusinessLayer.Abstract
{
    public interface ICategoryPropertyService
    {
        CategoryProperties GetById(int id);
        List<CategoryProperties> GetAll();
        void Create(CategoryProperties categoryProperties);
        void Update(CategoryProperties categoryProperties);
        void Delete(CategoryProperties categoryProperties);
    }
}
