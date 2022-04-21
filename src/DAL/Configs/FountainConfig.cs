using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class FountainConfig : IEntityTypeConfiguration<Fountain>
    {
        public void Configure(EntityTypeBuilder<Fountain> builder)
        {
            builder.ToTable("Fountain");

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

            builder.Property(x => x.WaterType)
                .HasColumnName("WaterType")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.InMemoryOf)
                .HasColumnName("InMemoryOf")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
