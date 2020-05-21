using System.Collections.Generic;
using MyFitnessProgress.Infrastructure.DTO;

namespace MyFitnessProgress.Infrastructure.Services.Abstraction
{
    public interface IProductsService
    {
        List<ProductDto> GetAllProducts(int userId);
        bool Add(ProductDto newProduct, int userId);
    }
}