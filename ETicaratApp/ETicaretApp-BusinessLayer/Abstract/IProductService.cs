﻿using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_BusinessLayer.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        //Product GetByIdWithCategories(int id);
        //Product GetProductDetails(int id);
        List<Product> GetAll();
        //List<Product> GetProductsByCategory(string category, int page, int pageSize);
        //int GetCountByCategory(string category);
        bool Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetProductListWithCategory();
    }
}
