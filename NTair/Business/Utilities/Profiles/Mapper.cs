using Entities.Concrete;
using Entities.DTOs.Auth;
using Entities.DTOs.Product;

namespace Business.Utilities.Profiles;

public class Mapper:Profile
{
	public Mapper()
	{
		CreateMap<ProductCreateDto, Product>();
		CreateMap<Product, ProductGetDto>();
		CreateMap<ProductUpdateDto, Product>();
		CreateMap<RegisterDto, AppUser>();
    }
}
