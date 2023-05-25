using AutoMapper;
using Mango.Product.API.Registrations;

namespace Mango.Product.API.Providers
{
    public static class MapperConfigurationProvider
    {
        public static IMapperConfigurationExpression Get(IServiceProvider provider)
        {
            var cfg = new MapperConfigurationExpression();

            cfg.AddProfile<ProductProfile>();

            return cfg;
        }
    }
}
