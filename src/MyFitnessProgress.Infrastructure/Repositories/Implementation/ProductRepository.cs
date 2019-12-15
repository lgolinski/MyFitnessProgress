using System.Collections.Generic;
using System.Linq;
using MyFitnessProgress.Core.Domain.Diet;
using MyFitnessProgress.Infrastructure.Mappings;
using MyFitnessProgress.Infrastructure.Repositories.Abstraction;

namespace MyFitnessProgress.Infrastructure.Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly DietDbContext _dbConntext;
        public ProductRepository(DietDbContext dbContext)
        {
            _dbConntext = dbContext;
        }

        public List<Product> GetAll()
        {
            return _dbConntext.Products.ToList();
        }
    }
}