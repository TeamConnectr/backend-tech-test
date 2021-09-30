namespace Connectr.TechTests.Backend.EntityFramework
{
    public static class StarwarsDbInitializer
    {
        public static void Initialize(StarwarsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
