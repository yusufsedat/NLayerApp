using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using NLayerCore.Repositories;
using NLayerCore.Services;

namespace NLayerAPI.Controllers
{
  
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
       

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
         
        }



        [HttpGet("[action]/{categoryId}")]

        public async Task<IActionResult> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {

            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductAsync(categoryId));

        }
    }
}
