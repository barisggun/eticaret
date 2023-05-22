using ETicaretApp_DataAccess.Abstract;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : BaseEntity
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {

            return _context.Set<T>().Find(id);
        }

        public void Create(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).SingleOrDefault();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().Where(filter).ToList();
        }
    }
}
