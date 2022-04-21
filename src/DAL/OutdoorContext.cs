using Core.Entities;
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
        public DbSet<Lake> Dams { get; set; }
        public DbSet<Fountain> Fountains { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<NatureReserve> NatureReserves { get; set; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<LandmarkType> LandmarkTypes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6149JFK;Initial Catalog=Outdoors;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
