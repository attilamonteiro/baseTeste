using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyCrudApi.Interfaces.Repositories;
using MyCrudApi.Repositories;
using MyCrudApi.Services;

namespace MyCrudApi.Configuration
{
    public static class DependencyConfiguration
    {
        public static void ConfigureInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductsService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddAutoMapper(typeof(DependencyConfiguration).Assembly);
        }
    }
}
