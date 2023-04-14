using AutoMapper;
using WebApiConfig.DTOs.Auth;
using WebApiConfig.DTOs.Product;
using WebApiConfig.Entities;

namespace WebApiConfig.Profiles
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            //CreateMap<Product, ProductGetDto>().ReverseMap();
            CreateMap<Product, ProductGetDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<RegisterDto, AppUser>();

        }
    }
}
