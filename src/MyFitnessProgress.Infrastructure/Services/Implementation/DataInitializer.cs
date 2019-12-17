using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyFitnessProgress.Infrastructure.DTO;
using MyFitnessProgress.Infrastructure.Mappings;
using MyFitnessProgress.Infrastructure.Services.Abstraction;
using MyFitnessProgress.Infrastructure.Settings;

namespace MyFitnessProgress.Infrastructure.Services.Implementation
{
    public class DataInitializer : IDataInitializer
    {
        private readonly DietDbContext _dbContext;
        private readonly IProductsService _productsService;
        private readonly IOptions<DatabaseSettings> _dbSettings;
        public DataInitializer(DietDbContext dbContext, IProductsService productsService, IOptions<DatabaseSettings> dbSettings)
        {
            _dbContext = dbContext;
            _productsService = productsService;
            _dbSettings = dbSettings;
        }

        public void PrepareDatabase()
        {
            ExecuteMigrations();

            if (_dbSettings.Value.SeedData)
                SeedData();
        }
        private void ExecuteMigrations()
        {
            // Create Initial database.
            if (_dbSettings.Value.UseInMemoryDatabase)
                _dbContext.Database.EnsureCreated();

            // migrate database with all migration scripts.
            // Note: Migrations can be used only on real database. Not in In Memory Database.
            else if (!_dbSettings.Value.UseInMemoryDatabase && _dbSettings.Value.UseMigrations)
                _dbContext.Database.Migrate();
        }
        private void SeedData()
        {
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