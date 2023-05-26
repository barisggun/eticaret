using ETicaretApp_DataAccess.Abstract;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.Repositories;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        //public void DeleteFromCategory(int categoryId, int productId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category GetByIdWithProducts(int id)
        //{
        //    using (var context = new Context())
        //    {
        //        return context.Categories.Where(x => x.Id == id)
        //                                 .Include(x => x.SubCategorie)
        //                                 .Include(x => x.ProductCategory)
        //                                 .ThenInclude(x => x.Product)
        //                                 .FirstOrDefault();
        //    }
        //}
    }
}
