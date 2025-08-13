using JobApi.Interface;
using JobApi.Model;
using JobApi.Models;
using JobApi.Service;
using JobPortalAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServicecs _userService;

        public UserController(IUserServicecs userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTO userRegisterDto)
        {
            try
            {
                var user = await _userService.RegisterUserAsync(userRegisterDto);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO userLoginDto)
        {
            try
            {
                var user = await _userService.LoginUserAsync(userLoginDto);

                // Save the userId in session
                HttpContext.Session.SetInt32("UserId", user.UserId);

                return Ok(new { message = "Login successful", userId = user.UserId, name = user.Name });
            }
            catch (Exception ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}





    
