namespace MyFitnessProgress.Infrastructure.DTO
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public UnitDto Unit { get; set; }
        public MacroDto Macro { get; set; }
    }
}