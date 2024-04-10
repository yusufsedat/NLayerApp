using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayerCore.DTOs;
using NLayerCore.Models;
using NLayerCore.Services;
using NLayerWeb.Services;

namespace NLayerWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductApiService _productApiService;
        private readonly CategoryApiService _categoryApiService;

        public ProductsController(CategoryApiService categoryApiService, ProductApiService productApiService)
        {
            _categoryApiService = categoryApiService;
            _productApiService = productApiService;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _productApiService.GetProductWithCategoryAsync());
        }

        public async Task<IActionResult> Save()
        {
            var categories = await _categoryApiService.GetAllAsync();

            
            ViewBag.categories = new SelectList(categories, "Id", "Name");

            return View();

        }

        [HttpPost]

        public async Task<IActionResult> Save(ProductDto productDto)
        {


            if (ModelState.IsValid)
            {   
                await _productApiService.SaveAsync(productDto);

                return RedirectToAction(nameof(Index));

            }

            var categories = await _categoryApiService.GetAllAsync();


            ViewBag.categories = new SelectList(categories, "Id", "Name");

            return View();

        }

        [ServiceFilter(typeof(NotFoundFilters<Product>))]
        public async Task<IActionResult> Update(int id)
        {
            var product = await _productApiService.GetByIdAsync(id);

            var categories = await _categoryApiService.GetAllAsync();


            ViewBag.categories = new SelectList(categories, "Id", "Name", product.CategoryId);

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                await _productApiService.UpdateAsync(productDto);
                return RedirectToAction(nameof(Index));
            }

            var categories = await _categoryApiService.GetAllAsync();


            ViewBag.categories = new SelectList(categories, "Id", "Name", productDto.CategoryId);


            return View(productDto);
        }

        [ServiceFilter(typeof(NotFoundFilters<Product>))]
        public async Task<IActionResult> Remove (int id)
        {
            await _productApiService.RemoveAsync(id);
             
            return RedirectToAction(nameof(Index));

        }
    }
}
