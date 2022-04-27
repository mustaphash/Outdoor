using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class WaterTypeConfig : IEntityTypeConfiguration<WaterType>
    {
        public void Configure(EntityTypeBuilder<WaterType> builder)
        {
            builder.ToTable("WaterTypes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(200)
                .IsRequired();

            builder.HasData(
                new WaterType
                {
                    Id = 1,
                    Name = "Mineral"
                },
                new WaterType
                {
                    Id = 2,
                    Name = "Spring"
                },
                new WaterType
                {
                    Id = 3,
                    Name = "Table"
                }
                );
        }
    }
}
