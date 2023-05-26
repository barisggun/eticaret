using ETicaretApp_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> GetListWithCategory();
        //List<Product> GetProductsByCategory(string category, int page, int pageSize);

        //Product GetProductDetails(int id);

        ////int GetCountByCategory(string category);
        //Product GetByIdWithCategories(int id);
        //void Update(Product entity, int[] categoryIds);
    }
}
