﻿using Core.Entities;
using DAL.Configs;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class OutdoorContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public OutdoorContext()
        {
        }

        public OutdoorContext(DbContextOptions options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {
        }
        public DbSet<Outdoor> Outdoors { get; set; }
        public DbSet<Extras> Extras { get; set; }
        public DbSet<Lake> Dams { get; set; }
        public DbSet<Fountain> Fountains { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<NatureReserve> NatureReserves { get; set; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<Animal> Animals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6149JFK;Initial Catalog=Outdoors;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfig());
            modelBuilder.ApplyConfiguration(new FountainConfig());
            modelBuilder.ApplyConfiguration(new LakeConfig());
            modelBuilder.ApplyConfiguration(new LandmarkConfig());
            modelBuilder.ApplyConfiguration(new NatureReserveConfig());
            modelBuilder.ApplyConfiguration(new OutdoorConfig());
            modelBuilder.ApplyConfiguration(new ParkConfig());
            modelBuilder.ApplyConfiguration(new VillaConfig());
            modelBuilder.ApplyConfiguration(new ExtrasConfig());
        }
    }
}
