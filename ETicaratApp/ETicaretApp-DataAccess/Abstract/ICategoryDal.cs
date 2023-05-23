using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        //Category GetByIdWithProducts(int id);
        //void DeleteFromCategory(int categoryId, int productId);
    }
}
