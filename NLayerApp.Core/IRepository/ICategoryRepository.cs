using NLayerApp.Core.Entity;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.IRepository
{
    internal interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<Cate>
    }
}
