using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFitnessProgress.Core.Domain.Diet;

namespace MyFitnessProgress.Infrastructure.Mappings.diet
{
    public class MacroMappings : IEntityTypeConfiguration<Macro>
    {
        public void Configure(EntityTypeBuilder<Macro> builder)
        {
            builder.HasKey(_ => _.MacroId);
        }
    }
}