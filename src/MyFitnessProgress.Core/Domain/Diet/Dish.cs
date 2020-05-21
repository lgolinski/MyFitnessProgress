using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public Macro Macro { get; set; }
        public int MacroId { get; set; }
        public bool IsDeleted { get; set; }
    }
}