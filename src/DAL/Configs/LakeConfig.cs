using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class LakeConfig : IEntityTypeConfiguration<Lake>
    {
        public void Configure(EntityTypeBuilder<Lake> builder)
        {
            builder.ToTable("Lake");

        }
    }
}
