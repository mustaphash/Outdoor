using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class VillaConfig : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> builder)
        {
            builder.ToTable("Villas");

            builder.Property(x => x.RoomCount)
                .HasColumnName("RoomCount")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(x => x.GuestCount)
                .HasColumnName("GuestCount")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(x => x.ParkingCount)
                .HasColumnName("ParkingCount")
                .IsRequired();
        }
    }
}
