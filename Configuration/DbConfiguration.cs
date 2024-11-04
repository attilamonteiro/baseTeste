using Microsoft.EntityFrameworkCore;
using MyCrudApi.Data;

namespace MyCrudApi.Configuration
{
    public static class DbConfiguration
    {
        public static void AddConnections(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=ProductsDb.db")
                   .EnableSensitiveDataLogging()
                   .LogTo(Console.WriteLine, LogLevel.Information));
        }
    }
}
