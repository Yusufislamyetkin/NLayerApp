using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entity;
using NLayerApp.Core.IRepository;
using NLayerApp.Repository.Context;

namespace NLayerApp.Repository.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {


        public CategoryRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<List<Category>> getCategoriesByIdWithProductsDto(int id)
        {
            return await _db.categories.Include(x => x.Products).Where(x => x.Id == id).ToListAsync();
        }
    }
}
