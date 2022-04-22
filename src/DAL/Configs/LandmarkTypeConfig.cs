using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class LandmarkTypeConfig : IEntityTypeConfiguration<LandmarkType>
    {
        public void Configure(EntityTypeBuilder<LandmarkType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Height)
                .HasColumnName("Height");
        }
    }
}
