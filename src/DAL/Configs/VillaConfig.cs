﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class VillaConfig : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> builder)
        {
            builder.ToTable("Villa");


            builder.Property(x => x.RoomCount)
                .HasColumnName("RoomCount")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.ParkingCount)
                .HasColumnName("ParkingCount")
                .IsRequired();
        }
    }
}