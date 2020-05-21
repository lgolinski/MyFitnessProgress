using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFitnessProgress.Core.Domain.Diet;

namespace MyFitnessProgress.Infrastructure.Mappings.diet
{
    public class ProductCategoryMappings : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(_ => _.ProductCategoryId);
            builder.HasIndex(_ => _.Name).IsUnique();
            builder.Property(_ => _.Name).HasMaxLength(100);

            builder.HasData(
                new ProductCategory { ProductCategoryId = 1, Name = "Nabiał" },
                new ProductCategory { ProductCategoryId = 2, Name = "Mięso i wyroby mięsne" },
                new ProductCategory { ProductCategoryId = 3, Name = "Ryby i owoce morza" },
                new ProductCategory { ProductCategoryId = 4, Name = "Pieczywo" },
                new ProductCategory { ProductCategoryId = 5, Name = "Zbożowe" },
                new ProductCategory { ProductCategoryId = 6, Name = "Orzechy i ziarna" },
                new ProductCategory { ProductCategoryId = 7, Name = "Napoje" },
                new ProductCategory { ProductCategoryId = 8, Name = "Tłuszcze" },
                new ProductCategory { ProductCategoryId = 9, Name = "Inne" },
                new ProductCategory { ProductCategoryId = 10, Name = "Owoce i Warzywa" },
                new ProductCategory { ProductCategoryId = 11, Name = "Przyprawy i zioła" }
            );
        }
    }
}