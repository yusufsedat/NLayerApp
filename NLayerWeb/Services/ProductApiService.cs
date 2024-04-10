using NLayerCore.DTOs;
using NLayerService.Validations;

namespace NLayerWeb.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;

        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductWithCategoryDto>> GetProductWithCategoryAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("products/GetProductsWithCategory");

            return response.Data;

        }
        public async Task<ProductDto> SaveAsync (ProductDto product)
        {
            var response = await _httpClient.PostAsJsonAsync("products" , product);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductDto>>();
            return responseBody.Data;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<ProductDto>>($"products/{id}");
            return response.Data;
        }
        public async Task<bool> UpdateAsync(ProductDto product)
        {
            var response = await _httpClient.PutAsJsonAsync("products", product);

            return response.IsSuccessStatusCode;    
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"products/{id}");

            return response.IsSuccessStatusCode;
        }

    }
}
