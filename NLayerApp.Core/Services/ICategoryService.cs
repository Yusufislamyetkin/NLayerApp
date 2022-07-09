using NLayerApp.Core.DTOs;
using NLayerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Services
{
    public interface ICategoryService:IGenericService<Category>
    {
        Task<List<GetCategoriesByIdWithProductsDto>> getCategoriesByIdWithProductsDto(int id);
    }
}
