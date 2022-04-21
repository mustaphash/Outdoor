using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ParkConfig : IEntityTypeConfiguration<Park>
    {
        public void Configure(EntityTypeBuilder<Park> builder)
        {
            builder.ToTable("Park");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            //base prop?

            builder.Property(x => x.Safety)
                .HasColumnName("Safety")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Camping)
                .HasColumnName("Camping")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.WalkingPaths)
                .HasColumnName("WalkingPaths")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
