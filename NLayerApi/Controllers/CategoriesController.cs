using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using NLayerAPI.Filters;
using NLayerCore.DTOs;
using NLayerCore.Repositories;
using NLayerCore.Services;

namespace NLayerAPI.Controllers
{
    
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
            return CreateActionResult (CustomResponseDto<List<CategoryDto>> .Success(200,categoriesDto));

        }

        [HttpGet("[action]/{categoryId}")]

        public async Task<IActionResult> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {

            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductAsync(categoryId));

        }
    }
}
