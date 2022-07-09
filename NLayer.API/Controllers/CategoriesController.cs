using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.IUnitOfWork;
using NLayerApp.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        ICategoryService _categoryService;
        IUnitOfWork _unitOfWork;

        public CategoriesController(ICategoryService categoryService, IUnitOfWork unitOfWork)
        {
            _categoryService = categoryService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> getCategoriesByIdWithProductsDto(int id)
        {
           var value =   await _categoryService.getCategoriesByIdWithProductsDto(id);
            return CreateActionResult(CustomResponseDto<List<GetCategoriesByIdWithProductsDto>>.Success(200, value));
        }






    }
}
