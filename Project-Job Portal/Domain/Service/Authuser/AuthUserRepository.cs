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
        //    protected readonly HireMeNowDbContext _context;
        //    IMapper mapper;
        //    private readonly IConfiguration _configuration;
        //    public AuthUserRepository(HireMeNowDbContext dbContext, IMapper _mapper, IConfiguration configuration)
        //    {
        //        _context = dbContext;
        //        mapper = _mapper;
        //        _configuration = configuration;
        //    }

        //    public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
        //    {
        //        authUser.Role = Enums.Role.JOB_SEEKER;
        //        await _context.AuthUsers.AddAsync(authUser);
        //        Models.JobSeeker jobSeeker = mapper.Map<Models.JobSeeker>(authUser);
        //        await _context.JobSeekers.AddAsync(jobSeeker);
        //        JobSeekerProfile jp = new();
        //        jp.Id = Guid.NewGuid();
        //        jp.JobSeekerId = jobSeeker.Id;
        //        await _context.JobSeekerProfiles.AddAsync(jp);
        //        _context.SaveChanges();
        //        return authUser;
        //    }



        //    public string? CreateToken(AuthUser user)
        //    {
        //        string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;

        //        // Generate new session connection ID
        //        user.ConnectionId = Guid.NewGuid().ToString();
        //        user.OnlineStatus = true;
        //        _context.SaveChanges();

        //        List<Claim> claims = new List<Claim>
        //{
        //    new Claim(ClaimTypes.Name, user.FirstName),
        //    new Claim(ClaimTypes.Email, user.Email),
        //    new Claim(ClaimTypes.Sid, user.Id.ToString()),
        //    new Claim(ClaimTypes.Role, user.Role.ToString()),
        //    new Claim("ConnectionId", user.ConnectionId ?? "")
        //};

        //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
        //        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        //        var token = new JwtSecurityToken(
        //            claims: claims,
        //            expires: DateTime.Now.AddDays(1),
        //            signingCredentials: creds);

        //        return new JwtSecurityTokenHandler().WriteToken(token);
        //    }


        //    internal class AuthUserRepository : IAuthUserRepository
        //    {
        //        private readonly HireMeNowDbContext _context;
        //        IMapper _mapper;
        //        private readonly IConfiguration _configuration;
        //        public AuthUserRepository(HireMeNowDbContext context, IMapper mapper, IConfiguration configuration)
        //        {
        //            _context = context;
        //            _mapper = mapper;
        //            _configuration = configuration;

        //        }

        //        public string? CreateToken(AuthUser user)
        //        {
        //            if (user == null)
        //                throw new ArgumentNullException(nameof(user), "User cannot be null.");

        //            string tokenSecret = _configuration["AuthSettings:Token"];
        //            if (string.IsNullOrEmpty(tokenSecret))
        //                throw new InvalidOperationException("Token secret is missing in configuration.");

        //            // ✅ Create claims for the user
        //            var claims = new List<Claim>
        //{
        //    new Claim(ClaimTypes.Name, user.FirstName), // optional
        //    new Claim(ClaimTypes.Email, user.Email),
        //    new Claim(ClaimTypes.Sid, user.Id.ToString()),
        //    new Claim(ClaimTypes.Role, user.Role?.ToString() ?? "Admin")
        //};

        //            // ✅ Generate symmetric key from secret
        //            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
        //            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        //            // ✅ Create JWT token
        //            var token = new JwtSecurityToken(
        //                claims: claims,
        //                expires: DateTime.Now.AddDays(1),
        //                signingCredentials: creds
        //            );

        //            // ✅ Return JWT as string
        //            return new JwtSecurityTokenHandler().WriteToken(token);
        //        }
        //    }
        private readonly HireMeNowDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthUserRepository(HireMeNowDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        // ✅ Register Job Seeker
        public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
           {
                authUser.Role = Enums.Role.JOB_SEEKER;
                await _context.AuthUsers.AddAsync(authUser);
                Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
                await _context.JobSeekers.AddAsync(jobSeeker);
                JobSeekerProfile jp = new();
                jp.Id = Guid.NewGuid();
                jp.JobSeekerId = jobSeeker.Id;
                await _context.JobSeekerProfiles.AddAsync(jp);
                _context.SaveChanges();
                return authUser;
            }

        // ✅ Register Admin (optional)
        public async Task<AuthUser> AddAuthUserAdmin(AuthUser authUser)
        {
            authUser.Role = Enums.Role.ADMIN;
            await _context.AuthUsers.AddAsync(authUser);
            await _context.SaveChangesAsync();
            return authUser;
        }

        // ✅ Common Token Creation for both roles
        public string? CreateToken(AuthUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            string tokenSecret = _configuration["AuthSettings:Token"];
            if (string.IsNullOrEmpty(tokenSecret))
                throw new InvalidOperationException("Token secret is missing in configuration.");

            // Assign Connection ID and update status
            user.ConnectionId = Guid.NewGuid().ToString();
            user.OnlineStatus = true;
            _context.SaveChanges();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName ?? string.Empty),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim("ConnectionId", user.ConnectionId ?? string.Empty)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
