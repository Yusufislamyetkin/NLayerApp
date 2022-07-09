using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Repositories;
using NLayerApp.Repository.Context;

namespace NLayerApp.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _db;
        private readonly DbSet<T> _dbset;

        public GenericRepository(AppDbContext db)
        {
            _db = db;
            _dbset = db.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            
            await _dbset.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbset.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _dbset.AnyAsync();
        }

        // Async olmasının sebebi remove methodu aslında kaldırma işini yapmaz savechange diyene kadar. SaveChange dendiğinde işaretlenmiş yerin silme işlemi gerçekleşir.
        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbset.AsNoTracking().AsQueryable();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _dbset.FindAsync(id);
            if (result != null)
            {
                _db.Entry(result).State = EntityState.Detached;
            }
            return result;

        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbset.Update(entity);
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
          return  _dbset.Where(expression);
        }
    }
}
