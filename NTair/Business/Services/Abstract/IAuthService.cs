using Core.Utilities.Security.JWT;
using Entities.DTOs.Auth;

namespace Business.Services.Abstract;

public interface IAuthService
{
    Task<IDataResult<AppUser>> Register(RegisterDto registerDto);
    Task<IDataResult<AppUser>> Login(LoginDto loginDto);
    Task<IDataResult<AccessToken>> CreateAccessToken(AppUser user);
}
