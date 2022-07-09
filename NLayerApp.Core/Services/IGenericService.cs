using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Services
{
    public interface IGenericService<T> where T : class 
    {
        //Veritabanına yansıtma işi olduğu için Task ile çalışıyoruz.
        // IQueryable task olmaz çünkü zaten amacı tolist denine kadar üzerinde işlem yapabilmemize olanak sağlamasıdır.

        Task<T> GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task<IEnumerable<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    
      

        //IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    }
}
