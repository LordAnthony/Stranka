using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.DAL
{
    public class Repository<T> where T : class
    {
        private StrankaContext _dbContext;

        public Repository()
        {
        }

        public async Task<int> Create(T entity)
        {
            using (_dbContext = new StrankaContext())
            {
                _dbContext.Set<T>().Add(entity);
                int result = await _dbContext.SaveChangesAsync();
                return result;
            }
        }

        public async Task<T> Read(Func<T, bool> predicate)
        {
            using (_dbContext = new StrankaContext())
            {
                T entity = await Task.Run(() => _dbContext.Set<T>().FirstOrDefault(predicate));
                return entity;
            }
        }

        public async Task<int> Update(T entity)
        {
            using (_dbContext = new StrankaContext())
            {
                _dbContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
                int result = await _dbContext.SaveChangesAsync();
                return result;
            }
        }

        public async Task<int> Delete(T entity)
        {
            using (_dbContext = new StrankaContext())
            {
                _dbContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
                int result = await _dbContext.SaveChangesAsync();
                return result;
            }
        }

        public async Task<List<T>> GetAll()
        {
            using (_dbContext = new StrankaContext())
            {
                List<T> entity = await Task.Run(() => _dbContext.Set<T>().ToList());
                return entity;
            }
        }

        public async Task<List<T>> Search(Func<T, bool> predicate)
        {
            using (_dbContext = new StrankaContext())
            {
                List<T> entity = await Task.Run(() => _dbContext.Set<T>().Where(predicate).ToList());
                return entity;
            }
        }

    }
}
