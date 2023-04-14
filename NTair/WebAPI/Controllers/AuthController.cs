﻿using Business.Services.Abstract;
using Entities.DTOs.Auth;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        var result= await _authService.Register(registerDto);
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var result = await _authService.Login(loginDto);
        if (!result.Success)
        {
            return BadRequest(result);
        }
        var accessToken = await _authService.CreateAccessToken(result.Data);
        return Ok(accessToken);
    }
}
