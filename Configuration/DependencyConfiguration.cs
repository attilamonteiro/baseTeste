using MyCrudApi.Services;

namespace MyCrudApi.Configuration
{
    public static class DependencyConfiguration
    {
        public static void ConfigureInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<ProductsService>();
        }
    }
}
