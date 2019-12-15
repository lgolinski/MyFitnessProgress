using System.Collections.Generic;
using MyFitnessProgress.Core.Domain.Diet;

namespace MyFitnessProgress.Infrastructure.Repositories.Abstraction
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        int Add(Product product);
    }
}