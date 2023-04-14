using Core.Entities;

namespace Entities.DTOs.Auth;

public class RegisterDto:IDTO
{
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
