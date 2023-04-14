using Microsoft.AspNetCore.Identity;

namespace WebApiConfig.Entities
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
