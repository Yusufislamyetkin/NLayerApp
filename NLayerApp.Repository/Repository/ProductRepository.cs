using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entity;
using NLayerApp.Core.IRepository;
using NLayerApp.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository

    {
        public ProductRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<List<Product>> GetProductsWitCategory()
        {

            return await _db.products.Include(x => x.Category).ToListAsync();
        }

    
    }
}
