using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ExtrasConfig : IEntityTypeConfiguration<Extras>
    {
        public void Configure(EntityTypeBuilder<Extras> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(500)
                .IsRequired();

            builder.HasData(
                new Extras 
                {
                    Id = 1,
                    Name = "Wi-Fi" 
                },
                new Extras 
                {
                    Id = 2,
                    Name = "Camping"
                },
                new Extras 
                { 
                    Id = 3,
                    Name = "FishingAllowed"
                },
                new Extras { 
                    Id = 4, 
                    Name = "Elrctricity" 
                },
                new Extras 
                {
                    Id = 5,
                    Name = "OpenForTourist" 
                },
                new Extras 
                {
                    Id = 6,
                    Name = "WalkingPaths" 
                });
        }
    }
}
