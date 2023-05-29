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
    public class PropertyValueManager : IPropertyValueService
    {
        private IPropertyValueDal _propertyValue;

        public PropertyValueManager(IPropertyValueDal propertyValue)
        {
            _propertyValue = propertyValue;
        }

        public void Create(PropertyValue propertyValue)
        {
            _propertyValue.Create(propertyValue);
        }

        public void Delete(PropertyValue propertyValue)
        {
            _propertyValue.Delete(propertyValue);
        }

        public List<PropertyValue> GetAll()
        {
            return _propertyValue.GetAll();
        }

        public PropertyValue GetById(int id)
        {
            return _propertyValue.GetById(id);
        }

        public void Update(PropertyValue propertyValue)
        {
            _propertyValue.Update(propertyValue);
        }
    }
}
