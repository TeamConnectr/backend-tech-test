using Connectr.TechTests.Backend.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Connectr.TechTests.Backend.EntityFramework
{
    public class StarwarsDbContext : DbContext
    {
        public StarwarsDbContext(DbContextOptions<StarwarsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Film> Films { get; set; }

        public DbSet<Planet> Planets { get; set; }

        public DbSet<Species> Species { get; set; }

        public DbSet<Starship> Starships { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Planet>()
                .Property(p => p.Gravity)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Planet>()
                .Property(p => p.SurfaceWater)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Species>()
                .Property(p => p.AverageHeight)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Species>()
                .Property(p => p.AverageLifespan)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Starship>()
                .Property(p => p.HyperdriveRating)
                .HasColumnType("decimal(18,4)");
        }
    }
}
