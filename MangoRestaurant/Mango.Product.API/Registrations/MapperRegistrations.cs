using Mango.Product.API.Providers;

namespace Mango.Product.API.Registrations
{
    public static class MapperRegistrations
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper((cfg) => MapperConfigurationProvider.Get(services.BuildServiceProvider()));

            return services;
        }
    }
}
