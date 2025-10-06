using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Login___JWT.Dto;
using Login___JWT.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Login___JWT.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _userDbContext;
        private readonly IConfiguration configuration;

        public UserController (UserDbContext userDbContext, IConfiguration _configuration)
        {
            _userDbContext = userDbContext;
            configuration = _configuration;
        }

        [HttpPost]
        [Route("Registration")]

        public IActionResult Registration(UserDto userDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var objUser = _userDbContext.Users.FirstOrDefault(x => x.Email == userDto.Email);
            if(objUser == null)
            {
                _userDbContext.Users.Add(new Model.User
                {
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Email = userDto.Email,
                    Password = userDto.Password,
                    Role = userDto.Role,
                });
                _userDbContext.SaveChanges();
                return Ok("User Registered Successfully");
            }
            else
            {
                return BadRequest("User Already Exists with same email address");
            }
        }

        [HttpPost]
        [Route("Login")]

        public IActionResult Login (LoginDto loginDto)
        {
            var user = _userDbContext.Users.FirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);
            if(user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, configuration["JWT:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                     new Claim("UserId", user.UserId.ToString()),
                     new Claim("Email", user.Email),
                     new Claim(ClaimTypes.Role, user.Role.ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));

                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    configuration["JWT:Issuer"],
                    configuration["JWT:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn
                    );

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user });
            }
            return NoContent();
        }

        [HttpGet]
        [Route("GetUser")]
        [Authorize(Roles = "JobSeeker")]
        public IActionResult GetUser(int id)
        {
            var user = _userDbContext.Users.FirstOrDefault(x => x.UserId == id);
            if (user != null)
            {
                return Ok(user);
            }
            else
                return NoContent();
        }

        [HttpDelete]
        [Route("DeleteUser")]
        [Authorize(Roles = "Admin,JobProvider")]
        public IActionResult DeleteUser(int id)
        {
            var user = _userDbContext.Users.FirstOrDefault(x => x.UserId == id);
            if (user != null)
            {
                _userDbContext.Users.Remove(user);
                _userDbContext.SaveChanges();
                return Ok("User Deleted Successfully");
            }
            return NotFound("User Not Found");
        }
    }
}
