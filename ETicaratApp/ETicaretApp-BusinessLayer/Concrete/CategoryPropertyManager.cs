using ETicaretApp_BusinessLayer.Abstract;
using ETicaretApp_DataAccess.Abstract;
using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_BusinessLayer.Concrete
{
    public class CategoryPropertyManager : ICategoryPropertyService
    {
        private ICategeoryPropertyDal _catPropertyDal;

        public CategoryPropertyManager(ICategeoryPropertyDal catPropertyDal)
        {
            _catPropertyDal = catPropertyDal;
        }

        public void Create(CategoryProperties categoryProperties)
        {
            _catPropertyDal.Create(categoryProperties);
        }

        public void Delete(CategoryProperties categoryProperties)
        {
            _catPropertyDal.Delete(categoryProperties);
        }

        public List<CategoryProperties> GetAll()
        {
            return _catPropertyDal.GetAll();
        }

        public CategoryProperties GetById(int id)
        {
            return _catPropertyDal.GetById(id);
        }

        public void Update(CategoryProperties categoryProperties)
        {
            _catPropertyDal.Update(categoryProperties);
        }
    }
}
