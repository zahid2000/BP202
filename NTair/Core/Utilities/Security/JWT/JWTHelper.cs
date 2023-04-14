using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Core.Utilities.Security.JWT;

public class JWTHelper : ITokenHelper
{
    private readonly IConfiguration _configuration;
    private TokenOptions _tokenOptions;
    private DateTime _accessTokenExpiration;
    public JWTHelper(IConfiguration configuration)
    {
        _configuration = configuration;
        _tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
        _accessTokenExpiration = DateTime.UtcNow.AddMinutes(_tokenOptions.AccessTokenExpiration);
    }



    public AccessToken CreateToken(List<Claim> claims)
    {
        JwtHeader jwtHeader = CreateJWTHeader(_tokenOptions);
        JwtPayload jwtPayload = CreateJWTPayload(_tokenOptions,claims);
        JwtSecurityToken securityToken = CreateJWTSecurityToken(jwtHeader,jwtPayload);
         
        string token=new JwtSecurityTokenHandler().WriteToken(securityToken);
        return new AccessToken
        {
            Token = token,
            Expiration = _accessTokenExpiration
        };

    }
    private JwtHeader CreateJWTHeader(TokenOptions tokenOptions)
    {
        SecurityKey securityKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey);
        SigningCredentials signingCredentials = SigninCredentialsHelper.CreateSigninCredentials(securityKey);
        return new JwtHeader(signingCredentials);
    }
    private JwtPayload CreateJWTPayload(TokenOptions tokenOptions,List<Claim> claims)
    {
        return new JwtPayload(
            issuer:tokenOptions.Issuer,
            audience:tokenOptions.Audience,
            claims:claims,
            notBefore:DateTime.UtcNow,
            expires:_accessTokenExpiration
            );
    }
    private JwtSecurityToken CreateJWTSecurityToken(JwtHeader jwtHeader, JwtPayload jwtPayload)
    {
        return new JwtSecurityToken(jwtHeader,jwtPayload);
    }
}
