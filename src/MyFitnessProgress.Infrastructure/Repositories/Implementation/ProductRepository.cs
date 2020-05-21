using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
            return _dbConntext
            .Products
            .Include(x => x.Unit)
            .Include(x => x.Macro)
            .ToList();
        }

        public int Add(Product product)
        {
            _dbConntext.Products.Add(product);
            var createdProductId = _dbConntext.SaveChanges();

            return createdProductId;
        }
    }
}