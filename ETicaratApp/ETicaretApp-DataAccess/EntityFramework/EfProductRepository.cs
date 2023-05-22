using ETicaretApp_DataAccess.Abstract;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.Repositories;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EfProductRepository(Context context) : base(context)
        {
            _context = context;
        }

        public Product GetByIdWithCategories(int id)
        {
            return _context.Products
                        .Where(i => i.Id == id)
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .FirstOrDefault();
        }

        public int GetCountByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity, int[] categoryIds)
        {
            throw new NotImplementedException();
        }
    }
}
