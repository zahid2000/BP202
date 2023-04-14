using Core.Utilities.Security.JWT;
using Entities.DTOs.Auth;
using System.Security.Claims;

namespace Business.Services.Concrete;

public class AuthService : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenHelper _tokenHelper;
    private readonly IMapper _mapper;

    public AuthService(UserManager<AppUser> userManager, ITokenHelper tokenHelper, IMapper mapper)
    {
        _userManager = userManager;
        _tokenHelper = tokenHelper;
        _mapper = mapper;
    }

    public async Task<IDataResult<AccessToken>> CreateAccessToken(AppUser user)
    {
        IList<Claim> claims = await _userManager.GetClaimsAsync(user);
        var accessToken = _tokenHelper.CreateToken(claims.ToList());
        return new SuccessDataResult<AccessToken>(accessToken);
    }

    public async Task<IDataResult<AppUser>> Login(LoginDto loginDto)
    {
        AppUser appUser = await _userManager.FindByNameAsync(loginDto.UserName);
        if (appUser is  null)
        {
            return new ErrorDataResult<AppUser>(appUser, "User is not exists");
        }

        return new SuccessDataResult<AppUser>(appUser, "Login Successfully");
    }

    public async Task<IDataResult<AppUser>> Register(RegisterDto registerDto)
    {
        AppUser appUserForCheck = await _userManager.FindByNameAsync(registerDto.UserName);
        if (appUserForCheck is not null)
        {
            return new ErrorDataResult<AppUser>(appUserForCheck, "User already exists");
        }
        var user = _mapper.Map<AppUser>(registerDto);
        var result = await _userManager.CreateAsync(user, registerDto.Password);
        if (!result.Succeeded)
        {
            List<string> messages=new List<string>();
            foreach (var item in result.Errors)
            {
                messages.Add(item.Description);
            }
            return new ErrorDataResult<AppUser>(user, messages.ToArray());
        }

        await _userManager.AddClaimsAsync(user, new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim("FullName", user.FullName)        });

        return new SuccessDataResult<AppUser>(user, "Registered successfully");
    }
}
