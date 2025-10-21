using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Service.Authuser
{
    internal class AuthUserRepository : IAuthUserRepository
    {
        private readonly HireMeNowDbContext _context;
        IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AuthUserRepository(HireMeNowDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;

        }

        public string? CreateToken(AuthUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            string tokenSecret = _configuration["AuthSettings:Token"];
            if (string.IsNullOrEmpty(tokenSecret))
                throw new InvalidOperationException("Token secret is missing in configuration.");

            // ✅ Create claims for the user
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, user.FirstName), // optional
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Sid, user.Id.ToString()),
        new Claim(ClaimTypes.Role, user.Role?.ToString() ?? "Admin")
    };

            // ✅ Generate symmetric key from secret
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            // ✅ Create JWT token
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            // ✅ Return JWT as string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
