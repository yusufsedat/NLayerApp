using AutoMapper;
using NLayerCore.DTOs;
using NLayerCore.Models;
using NLayerCore.Repositories;
using NLayerCore.Services;
using NLayerCore.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerService.Services
{
    public class ProductService : Service<Product>, IProductService
    {   

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> repository, IMapper mapper, IProductRepository productRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);

            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsDto);

        }
    }
}
