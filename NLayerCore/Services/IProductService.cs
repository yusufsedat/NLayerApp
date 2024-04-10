using NLayerCore.DTOs;
using NLayerCore.Models;

namespace NLayerCore.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
