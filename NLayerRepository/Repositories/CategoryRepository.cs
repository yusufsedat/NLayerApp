using Microsoft.EntityFrameworkCore;
using NLayerCore.Models;
using NLayerCore.Repositories;

namespace NLayerRepository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();

        }
    }
}
