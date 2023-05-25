using AutoMapper;
using Mango.Product.API.DTOs;

namespace Mango.Product.API.Registrations
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Data.Models.Product, ProductDTO>();
        }
    }
}
