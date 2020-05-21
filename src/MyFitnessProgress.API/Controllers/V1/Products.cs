using Microsoft.AspNetCore.Mvc;
using MyFitnessProgress.API.Contracts.V1;
using MyFitnessProgress.Infrastructure.Services.Abstraction;

namespace MyFitnessProgress.API.Controllers.V1
{
    public class Products : Controller
    {
        private readonly IProductsService _productsService;
        public Products(IProductsService productsService)
        {
            _productsService = productsService;
        }

        /// <summary>
        /// Get all products created by user.
        /// </summary>
        /// <returns>
        ///     List of all products.
        /// </returns>
        [HttpGet(ApiRoutes.Products.GetAll)]
        public IActionResult GetAll()
        {
            var products = _productsService.GetAllProducts(1);

            return Ok(products);
        }
    }
}