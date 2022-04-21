using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class VillaConfig : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            //base prop?

            builder.Property(x => x.RoomCount)
                .HasColumnName("RoomCount")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.WiFi)
                .HasColumnName("Wi-Fi")
                .HasDefaultValue(true)
                .IsRequired();


        }
    }
}
