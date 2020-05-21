using System.Collections.Generic;
using AutoMapper;
using MyFitnessProgress.Core.Domain.Diet;
using MyFitnessProgress.Infrastructure.DTO;
using MyFitnessProgress.Infrastructure.Repositories.Abstraction;
using MyFitnessProgress.Infrastructure.Services.Abstraction;

namespace MyFitnessProgress.Infrastructure.Services.Implementation
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductsService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public List<ProductDto> GetAllProducts(int userId)
        {
            var products = _productRepository.GetAll();

            return _mapper.Map<List<Product>, List<ProductDto>>(products);
        }

        public bool Add(ProductDto newProduct, int userId)
        {
            var productToAdd = _mapper.Map<ProductDto, Product>(newProduct);
            productToAdd.Unit = null;

            var idCreated = _productRepository.Add(productToAdd);

            return idCreated > 0;
        }
    }
}