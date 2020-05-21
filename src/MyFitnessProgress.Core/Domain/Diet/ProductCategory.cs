using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}