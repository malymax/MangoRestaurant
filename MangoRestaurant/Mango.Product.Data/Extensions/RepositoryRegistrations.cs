using Mango.Product.Data.RA;
using Microsoft.Extensions.DependencyInjection;

namespace Mango.Product.Data.Extensions
{
    public static class RepositoryRegistrations
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
