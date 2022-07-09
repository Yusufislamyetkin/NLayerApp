using AutoMapper;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.Entity;
using NLayerApp.Core.IRepository;
using NLayerApp.Core.IUnitOfWork;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Concrete
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _IcategoryRepository;
        private readonly IMapper _Imapper;

        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> repository, ICategoryRepository categoryRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _IcategoryRepository = categoryRepository;
            _Imapper = mapper;
        }

        public async Task<List<GetCategoriesByIdWithProductsDto>> getCategoriesByIdWithProductsDto(int id)
        {
            var categories = await _IcategoryRepository.getCategoriesByIdWithProductsDto(id);
            return _Imapper.Map<List<GetCategoriesByIdWithProductsDto>>(categories);


        }
    }
}
