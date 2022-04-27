using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ParkConfig : IEntityTypeConfiguration<Park>
    {
        public void Configure(EntityTypeBuilder<Park> builder)
        {
            builder.ToTable("Parks");

            builder.Property(x => x.Safety)
                .HasColumnName("Safety")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
