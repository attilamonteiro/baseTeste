using Microsoft.Extensions.DependencyInjection;
using MyCrudApi.Infrastructure.Repositories;
using MyCrudApi.Interfaces.Repositories;

namespace MyCrudApi.Infrastructure.Configuration
{
    public static class DependencyConfiguration
    {
        public static void ConfigureInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddAutoMapper(typeof(DependencyConfiguration).Assembly);
        }
    }
}
