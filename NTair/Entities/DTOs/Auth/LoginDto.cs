﻿namespace Entities.DTOs.Auth;

public class LoginDto : IDTO
{
    public string UserName { get; set; }
    public string Password { get; set; }
}