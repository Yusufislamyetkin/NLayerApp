using AutoMapper;
using NLayerApp.Core.Dto;
using NLayerApp.Core.Entity;

namespace NLayerApp.Service
{
    internal class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
