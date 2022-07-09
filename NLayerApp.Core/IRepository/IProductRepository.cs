using NLayerApp.Core.Entity;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.IRepository
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWitCategory();
    }
}
