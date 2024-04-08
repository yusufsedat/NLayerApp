using NLayerCore.Models;

namespace NLayerCore.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategory();

    }
}
