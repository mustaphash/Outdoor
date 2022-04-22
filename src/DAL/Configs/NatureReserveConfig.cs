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

            builder.Property(x => x.Size)
                .HasColumnName("Size")
                .IsRequired();
        }
    }
}
