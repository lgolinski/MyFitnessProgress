using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class Macro
    {
        public int MacroId { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Calories { get; set; }
        public bool IsDeleted { get; set; }
    }
}