using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using AutoMapper;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Service.Authuser
{
    public class AuthUserRepository : IAuthUserRepository
    {
<<<<<<< HEAD
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
=======
        protected readonly HireMeNowDbContext _context;
        IMapper mapper;
        private readonly IConfiguration _configuration;
        public AuthUserRepository(HireMeNowDbContext dbContext, IMapper _mapper, IConfiguration configuration)
        {
            _context = dbContext;
            mapper = _mapper;
            _configuration = configuration;
        }

        public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
        {
            authUser.Role = Enums.Role.JOB_SEEKER;
            await _context.AuthUsers.AddAsync(authUser);
            Models.JobSeeker jobSeeker = mapper.Map<Models.JobSeeker>(authUser);
            await _context.JobSeekers.AddAsync(jobSeeker);
            JobSeekerProfile jp = new();
            jp.Id = Guid.NewGuid();
            jp.JobSeekerId = jobSeeker.Id;
            await _context.JobSeekerProfiles.AddAsync(jp);
            _context.SaveChanges();
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
            return authUser;
        }


<<<<<<< HEAD
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
=======

        public string? CreateToken(AuthUser user)
        {
            string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;

            // Generate new session connection ID
            user.ConnectionId = Guid.NewGuid().ToString();
            user.OnlineStatus = true;
            _context.SaveChanges();

            List<Claim> claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, user.FirstName),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Sid, user.Id.ToString()),
        new Claim(ClaimTypes.Role, user.Role.ToString()),
        new Claim("ConnectionId", user.ConnectionId ?? "")
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
    }
}