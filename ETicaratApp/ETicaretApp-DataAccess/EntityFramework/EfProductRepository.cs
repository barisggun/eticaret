using ETicaretApp_DataAccess.Abstract;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.Repositories;
using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public EfProductRepository(Context context) : base(context)
        {
        }
    }
}
