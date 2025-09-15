using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Domain.Dto;
using Domain.Interface;
using Domain.Service;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userservice;

        public UserController(IUserService userservice)
        {
            _userservice = userservice;
        }

        [HttpPost]
        [Route("Registration")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDto userdto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var adduser = await _userservice.AddRegisterAsync(userdto);
                return Ok(adduser);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var result = await _userservice.LoginUserAsync(loginDto);
            if (result == null)
                return Unauthorized("Invalid credentials");

            return Ok(new { Token = result.Value.Token, User = result.Value.User });
        }

    }
}
