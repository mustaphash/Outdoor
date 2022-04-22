using Core.Entities;
using DAL.Configs;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class OutdoorContext : DbContext
    {
        public OutdoorContext()
        {
        }
        public OutdoorContext(DbContextOptions options)
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
            modelBuilder.Entity<Extras>().HasData(
                new Extras { Id = 1, Name = "Wi-Fi" },
                new Extras { Id = 2, Name = "Camping" },
                new Extras { Id = 3, Name = "FishingAllowed" },
                new Extras { Id = 4, Name = "Elrctricity" },
                new Extras { Id = 5, Name = "OpenForTourist" },
                new Extras { Id = 6, Name = "WalkingPaths" });
        }
    }
}
