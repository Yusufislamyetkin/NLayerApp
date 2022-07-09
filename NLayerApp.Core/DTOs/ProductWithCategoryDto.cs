using NLayerApp.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.DTOs
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto category { get; set; }
    }
}
