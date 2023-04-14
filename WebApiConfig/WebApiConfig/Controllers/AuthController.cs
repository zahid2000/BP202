using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiConfig.DTOs.Auth;
using WebApiConfig.Entities;

namespace WebApiConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly TokenOption tokenOption;
        public AuthController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _config = config;
            tokenOption = _config.GetSection("TokenOptions").Get<TokenOption>();
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            //await _roleManager.CreateAsync(new IdentityRole { Name = "admin" });
            AppUser user = _mapper.Map<AppUser>(registerDto);
            var createResult = await _userManager.CreateAsync(user);
            if (!createResult.Succeeded)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Errors = createResult.Errors
                });
            }
            //var  await _userManager.AddToRoleAsync(user, "admin");
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            AppUser user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user is null) return NotFound();
            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password)) Unauthorized();

            IList<string> roles = await _userManager.GetRolesAsync(user);
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim("Fullname",user.FullName)
            };
            claims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r)));



            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOption.SecurityKey));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            JwtHeader jwtHeader = new JwtHeader(credentials);


            JwtPayload jwtPayload = new JwtPayload(
                issuer: tokenOption.Issuer,
                audience: tokenOption.Audience,
                expires: DateTime.UtcNow.AddMinutes(tokenOption.AccessTokenExpiration),
                notBefore: DateTime.UtcNow,
                claims: claims
                );
            JwtSecurityToken securityToken = new JwtSecurityToken(jwtHeader, jwtPayload);
            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return Ok(new
            {
                Token = token,
                ExpireDate=DateTime.UtcNow.AddMinutes(tokenOption.AccessTokenExpiration),
                TokenOption=tokenOption
            });

        }




    }
}
