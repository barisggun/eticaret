﻿using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_BusinessLayer.Abstract
{
    public interface IPropertyValueService
    {
        PropertyValue GetById(int id);
        List<PropertyValue> GetAll();
        void Create(PropertyValue propertyValue);
        void Update(PropertyValue propertyValue);
        void Delete(PropertyValue propertyValue);
    }
}
