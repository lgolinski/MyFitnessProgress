using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int MacroId { get; set; }
        public Macro Macro { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }
        public int? ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public bool IsDeleted { get; set; }
    }
}