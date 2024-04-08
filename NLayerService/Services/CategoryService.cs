using AutoMapper;
using NLayerCore.DTOs;
using NLayerCore.Models;
using NLayerCore.Repositories;
using NLayerCore.Services;
using NLayerCore.UnitOfWorks;

namespace NLayerService.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> repository, ICategoryRepository categoryRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWithProductAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryWithProductsDto>(category);

            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryDto);

        }
    }
}
