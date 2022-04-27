using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class FountainConfig : IEntityTypeConfiguration<Fountain>
    {
        public void Configure(EntityTypeBuilder<Fountain> builder)
        {
            builder.ToTable("Fountains");

            builder.Property(x => x.InMemoryOf)
                .HasColumnName("InMemoryOf")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
