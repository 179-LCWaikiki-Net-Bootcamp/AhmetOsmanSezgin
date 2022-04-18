using System.Collections.Generic;
using System.Linq;
using ProductAPI.DbOperations;

namespace ProductAPI.Repositories
{
    public class BaseRepositroy<T> : IBaseRepository<T> where T : class
    {
        private readonly ProductDbContext _context;
        public BaseRepositroy(ProductDbContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}