using Microsoft.Extensions.DependencyInjection;
using MyCrudApi.Services;

namespace MyCrudApi.Domain.Configuration
{
    public static class DependencyConfiguration
    {
        public static void ConfigureDomainDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductsService>();
            services.AddAutoMapper(typeof(DependencyConfiguration).Assembly);


        }
    }
}
