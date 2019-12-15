using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public TimeSpan PreparationTime { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public bool IsDeleted { get; set; }
    }
}