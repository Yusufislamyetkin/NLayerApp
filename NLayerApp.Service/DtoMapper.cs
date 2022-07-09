using AutoMapper;
using NLayerApp.Core.Dto;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.Entity;

namespace NLayerApp.Service
{
    public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<ProductFeatureDto, ProductFeature>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDto>().ReverseMap();
        }
    }
}
