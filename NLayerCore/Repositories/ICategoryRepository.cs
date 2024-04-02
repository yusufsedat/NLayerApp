using NLayerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.Repositories
{
    public interface ICategoryRepository :IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId);
    }
}
