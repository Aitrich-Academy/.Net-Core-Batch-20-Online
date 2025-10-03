using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Domain.Extension;

namespace Domain.Service.Login
{
    public class LoginRequestRepository :ILoginRequestRepository
    {
        protected readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        public LoginRequestRepository(AppDbContext  dbContext, IConfiguration configuration)
        {
            _context = dbContext;
            _configuration = configuration;
        }

        public RegisterUser  GetUserByEmail(string email)
        {
            var user = _context.RegisterUsers.FirstOrDefault(e => e.Email == email);
            return user;
        }

        public string? CreateToken(RegisterUser  user)
        {
            if (user == null)
            {
                // Handle the case where the user object is null, e.g., by throwing an exception or returning null.
                throw new ArgumentNullException(nameof(user), "User object cannot be null.");
            }
            var claims = new[]
                {
                     new Claim(JwtRegisteredClaimNames.Sub, _configuration["JWT:Subject"]),
                     new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    // new Claim("UserId", user.UserId.ToString()),
                     new Claim("Email", user.Email),
                     new Claim(ClaimTypes.Role, user.Role.ToString()) // Add Role claim
                };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["JWT:Issuer"],
                _configuration["JWT:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: signIn
                );

            string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);


            return tokenValue;
        }

    }
}
