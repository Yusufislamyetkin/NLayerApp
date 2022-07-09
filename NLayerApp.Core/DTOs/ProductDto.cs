using NLayerApp.Core.DTOs;

namespace NLayerApp.Core.Dto
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }


    }
}
