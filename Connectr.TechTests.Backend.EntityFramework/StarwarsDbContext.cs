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
    }
}
