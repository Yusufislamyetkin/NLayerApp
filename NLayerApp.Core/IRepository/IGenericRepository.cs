using System.Linq.Expressions;

namespace NLayerApp.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        //Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        


    }
}
