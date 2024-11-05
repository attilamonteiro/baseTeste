using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyCrudApi.Services;

namespace MyCrudApi.Configuration
{
    public static class DependencyConfiguration
    {
        public static void ConfigureInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductsService>();

            services.AddAutoMapper(typeof(DependencyConfiguration).Assembly);
        }
    }
}
