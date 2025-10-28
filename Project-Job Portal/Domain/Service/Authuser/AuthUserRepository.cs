using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
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
        private readonly IMapper _mapper;

        public AuthUserRepository(HireMeNowDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }


        // Add Auth User for Job Provider
        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)
        {
            authUser.Role = Enums.Role.JOB_PROVIDER;

            await _context.AuthUsers.AddAsync(authUser);
            await _context.SaveChangesAsync();

            return authUser;
        }

        // Add Auth User for Job Seeker
        public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
        {
            authUser.Role = Enums.Role.JOB_SEEKER;

            await _context.AuthUsers.AddAsync(authUser);

            var jobSeeker = _mapper.Map<Domain.Models.JobSeeker>(authUser);

            await _context.JobSeekers.AddAsync(jobSeeker);

            JobSeekerProfile jp = new()
            {
                Id = Guid.NewGuid(),
                JobSeekerId = jobSeeker.Id
            };
            await _context.JobSeekerProfiles.AddAsync(jp);

            await _context.SaveChangesAsync();
            return authUser;
        }

        public async Task AddUserAsync(AuthUser user)
        {
            await _context.AuthUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public string CreateToken(AuthUser user)
        {
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Role, user.Role.ToString())
    };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["AuthSettings:Token"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}