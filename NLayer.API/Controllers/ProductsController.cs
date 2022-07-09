using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.Dto;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.Entity;
using NLayerApp.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Product> _service;
        private readonly IProductService _productservice;

        public ProductsController(IMapper mapper, IGenericService<Product> service, IProductService productService)
        {
            _mapper = mapper;
            _service = service;
            _productservice = productService;
        }



        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            var ProductsWithCategor = await _productservice.GetProductsWithCategory();
            return CreateActionResult(CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, ProductsWithCategor));
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            //return Ok( CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var products = await _service.GetByIdAsync(id);
            var productsDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var products = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);

            if (product == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "Bu id'ye sahip ürün bulunamadı"));
            }
            await _service.DeleteAsync(product);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
