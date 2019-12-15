using System.Collections.Generic;
using MyFitnessProgress.Core.Domain.Diet;
using MyFitnessProgress.Infrastructure.Repositories.Abstraction;

namespace MyFitnessProgress.Infrastructure.Repositories.Implementation
{
    public class InMemoryProductRepository : IProductRepository
    {
        public List<Product> GetAll() => new List<Product>
        {
                new Product
                {
                    ProductId = 1,
                    Name = "Chleb razowy",
                    MacroId = 1,
                    UnitId = 1,
                    Macro = new Macro
                    {
                        MacroId = 1,
                        Calories = 250,
                        Fat = 23,
                        Carbohydrates = 31,
                        Protein = 6
                    },
                    Unit = new Unit
                    {
                        Name = "Kromka",
                        UnitId = 1
                    }
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Olej rzepakowy",
                    MacroId = 2,
                    Macro = new Macro
                    {
                        MacroId = 2,
                        Calories = 250,
                        Fat = 23,
                        Carbohydrates = 31,
                        Protein = 6
                    },
                    UnitId = 2,
                    Unit = new Unit
                    {
                        UnitId = 2,
                        Name = "Mililitry"
                    }
                }
        };
    }
}