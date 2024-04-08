using NLayerCore.DTOs;
using NLayerCore.Models;

namespace NLayerCore.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductAsync(int categoryId);
    }
}
