using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFitnessProgress.Core.Domain.Diet;

namespace MyFitnessProgress.Infrastructure.Mappings.diet
{
    public class PictureMappings : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasKey(_ => _.PictureId);
        }
    }
}