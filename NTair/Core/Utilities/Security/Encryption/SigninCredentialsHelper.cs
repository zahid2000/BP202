using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption;

public class SigninCredentialsHelper
{
    public static SigningCredentials CreateSigninCredentials(SecurityKey securityKey)
    {
        return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
    }
}
