using NLayerApp.Core.Dto;
using NLayerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.DTOs
{
    public class GetCategoriesByIdWithProductsDto : CategoryDto
    {
        public ProductDto ProductDto { get; set; }
    }
}
