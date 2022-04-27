using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class OutdoorConfig : IEntityTypeConfiguration<Outdoor>
    {
        public void Configure(EntityTypeBuilder<Outdoor> builder)
        {
            builder.ToTable("Outdoors");

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(1000);

            builder.Property(x => x.Longitude)
                .HasColumnName("Longitude")
                .IsRequired();

            builder.Property(x => x.Latitude)
                .HasColumnName("Latitude")
                .IsRequired();

            builder.Property(x => x.Image)
                .HasColumnName("Image")
                .IsRequired();

            builder.Property(x => x.WorkingHours)
                .HasColumnName("WorkingHours")
                .IsRequired();

            builder.Property(x => x.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();

        }
    }
}
