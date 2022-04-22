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
        }
    }
}
