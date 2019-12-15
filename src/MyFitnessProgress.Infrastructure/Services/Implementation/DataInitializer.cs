using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFitnessProgress.Infrastructure.DTO;
using MyFitnessProgress.Infrastructure.Mappings;
using MyFitnessProgress.Infrastructure.Services.Abstraction;

namespace MyFitnessProgress.Infrastructure.Services.Implementation
{
    public class DataInitializer : IDataInitializer
    {
        private readonly DietDbContext _dbContext;
        private readonly IProductsService _productsService;
        public DataInitializer(DietDbContext dbContext, IProductsService productsService)
        {
            _dbContext = dbContext;
            _productsService = productsService;
        }
        public void SeedData()
        {
            _dbContext.Database.EnsureCreated();

            // migrate database with all migration scripts.
            // Note: Migrations can be used only on real database. Not in In Memory Database.
            // _dbContext.Database.Migrate();

            // create fake data for testing InMemoryDatabase.
            var products = GenerateNewProducts();
            foreach (var item in products)
            {
                _productsService.Add(item, 1);
            }
        }

        private List<ProductDto> GenerateNewProducts()
        {
            List<ProductDto> products = new List<ProductDto>();
            products.Add(new ProductDto
            {
                Name = "Banan",
                Macro = new MacroDto
                {
                    Calories = 142,
                    Carbohydrates = 36,
                    Fat = 1,
                    Protein = 2
                },
                Unit = new UnitDto
                {
                    Name = "Sztuka",
                    UnitId = 3
                }
            });
            products.Add(new ProductDto
            {
                Name = "Jogurt Skyr (Piątnica) 100g",
                Macro = new MacroDto
                {
                    Calories = 192,
                    Carbohydrates = 12.3M,
                    Fat = 0,
                    Protein = 36
                },
                Unit = new UnitDto
                {
                    Name = "Porcja",
                    UnitId = 6
                }
            });
            products.Add(new ProductDto
            {
                Name = "Jabłko",
                Macro = new MacroDto
                {
                    Calories = 32,
                    Carbohydrates = 7.3M,
                    Fat = 0.2M,
                    Protein = 0.2M
                },
                Unit = new UnitDto
                {
                    UnitId = 3,
                    Name = "Sztuka"
                }
            });

            return products;
        }
    }
}