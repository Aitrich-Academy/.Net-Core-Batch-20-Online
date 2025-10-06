using Domain.Service.JobProviders.Dto;
using Domain.Service.JobProviders.Interface;
using JobProviderApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobProviderApi.API.Auth
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : BaseApiController<AuthController>
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(JobProviderRegisterDto dto)
        {
            var token = await _userService.RegisterAsync(dto);
            if (token == null) return BadRequest("User already exists.");
            return Ok(new { Token = token });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(JobProviderLoginDto dto)
        {
            var token = await _userService.LoginAsync(dto);
            if (token == null) return Unauthorized("Invalid credentials.");
            return Ok(new { Token = token });
        }
    }
}

