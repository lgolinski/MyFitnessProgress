using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class DishDetail
    {
        public int DishDetailsId { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsDeleted { get; set; }
    }
}