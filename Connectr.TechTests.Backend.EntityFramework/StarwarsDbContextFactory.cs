using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Connectr.TechTests.Backend.EntityFramework
{
    public class StarwarsDbContextFactory : IDesignTimeDbContextFactory<StarwarsDbContext>
    {
        public StarwarsDbContext CreateDbContext(string[] args)
        {
            var connectrAppSettings = "/../Connectr.TechTests.Backend/appsettings.json";

            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile(Directory.GetCurrentDirectory() + connectrAppSettings)
                 .Build();

            var dbContextBuilder = new DbContextOptionsBuilder<StarwarsDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            dbContextBuilder.UseSqlServer(connectionString);

            return new StarwarsDbContext(dbContextBuilder.Options);
        }
    }
}
