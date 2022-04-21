using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class NatureReserveConfig : IEntityTypeConfiguration<NatureReserve>
    {
        public void Configure(EntityTypeBuilder<NatureReserve> builder)
        {
            builder.ToTable("NatureReserve");

            builder.HasKey(x=>x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            // ?inherit prop?

            builder.Property(x => x.OpenForTourist)
                .HasColumnName("OpenForTourist")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.Size)
                .HasColumnName("Size")
                .IsRequired();
        }
    }
}
