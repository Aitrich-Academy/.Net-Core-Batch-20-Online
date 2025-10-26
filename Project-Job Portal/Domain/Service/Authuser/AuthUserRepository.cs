using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Service.Authuser
{
    public class AuthUserRepository : IAuthUserRepository
    {
        private readonly HireMeNowDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthUserRepository(HireMeNowDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // Add JobProvider Auth User
        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)
        {
            await _context.AuthUsers.AddAsync(authUser);
            await _context.SaveChangesAsync();
            return authUser;
        }


        public async Task AddUserAsync(AuthUser user)
        {
            _context.AuthUsers.Add(user);
            await _context.SaveChangesAsync();
        }


        // Create JWT Token
        public string CreateToken(AuthUser user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role?.ToString() ?? "JOB_PROVIDER")
        };

            // ✅ Use your key from configuration
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(int.Parse(_configuration["JwtSettings:ExpiryMinutes"])),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}