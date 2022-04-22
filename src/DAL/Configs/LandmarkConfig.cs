using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class LandmarkConfig : IEntityTypeConfiguration<Landmark>
    {
        public void Configure(EntityTypeBuilder<Landmark> builder)
        {
            builder.ToTable("Landmark");

        }
    }
}
