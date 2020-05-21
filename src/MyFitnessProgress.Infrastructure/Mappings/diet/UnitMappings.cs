using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFitnessProgress.Core.Domain.Diet;

namespace MyFitnessProgress.Infrastructure.Mappings.diet
{
    public class UnitMappings : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            // Mappings for Unit table. 
            builder.Property(_ => _.Name)
                .HasMaxLength(100);

            builder
                .HasKey(_ => _.UnitId);

            builder
                .Property(_ => _.Name)
                .IsRequired();

            builder
                .HasIndex(_ => _.Name)
                .IsUnique();

            builder
                .HasData(
                    new Unit { UnitId = 1, Name = "Garść" },
                    new Unit { UnitId = 2, Name = "Łyżka" },
                    new Unit { UnitId = 3, Name = "Sztuka" },
                    new Unit { UnitId = 4, Name = "Litr" },
                    new Unit { UnitId = 5, Name = "Plaster" },
                    new Unit { UnitId = 6, Name = "Porcja" },
                    new Unit { UnitId = 7, Name = "Plasterek" },
                    new Unit { UnitId = 8, Name = "Opakowanie" },
                    new Unit { UnitId = 9, Name = "Łyżeczka" },
                    new Unit { UnitId = 10, Name = "Listek" },
                    new Unit { UnitId = 11, Name = "Kromka" },
                    new Unit { UnitId = 12, Name = "Szklanka" },
                    new Unit { UnitId = 13, Name = "Kostka" },
                    new Unit { UnitId = 14, Name = "Ząbek" },
                    new Unit { UnitId = 15, Name = "Liść" },
                    new Unit { UnitId = 16, Name = "Łodyga" },
                    new Unit { UnitId = 17, Name = "Kieliszek" },
                    new Unit { UnitId = 18, Name = "Kropla" },
                    new Unit { UnitId = 19, Name = "Szczypta" },
                    new Unit { UnitId = 20, Name = "Płat" },
                    new Unit { UnitId = 21, Name = "Rurka" },
                    new Unit { UnitId = 22, Name = "Kapsułka" },
                    new Unit { UnitId = 23, Name = "Miarka" },
                    new Unit { UnitId = 24, Name = "Pęczek" },
                    new Unit { UnitId = 25, Name = "Gałka" });
        }
    }
}