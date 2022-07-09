using AutoMapper;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.Entity;
using NLayerApp.Core.IRepository;
using NLayerApp.Core.IUnitOfWork;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Concrete
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> repository, IProductRepository productRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
             _productRepository = productRepository;
                 
        }

        public async Task<List<ProductWithCategoryDto>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWitCategory();

            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return productsDto;

        }
    }
}
