using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class LakeConfig : IEntityTypeConfiguration<Lake>
    {
        public void Configure(EntityTypeBuilder<Lake> builder)
        {
            builder.ToTable("Lake");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.CarPath);
            builder.Property(x => x.Longitude);
            builder.Property(x => x.Latitude);
            builder.Property(x => x.WorkingHours);
            builder.Property(x => x.CreateDate);

            builder.Property(x => x.FishingAllowed)
                .HasColumnName("FishingAllowed")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.Camping)
                .HasColumnName("Camping")
                .HasDefaultValue(true)
                .IsRequired();

        }
    }
}
