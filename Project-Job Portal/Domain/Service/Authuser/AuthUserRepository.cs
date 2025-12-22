
<<<<<<< HEAD
=======
////using AutoMapper;
////using Domain.Models;
////using Microsoft.Extensions.Configuration;
////using Microsoft.IdentityModel.Tokens;
////using System;
////using System.Collections.Generic;
////using System.IdentityModel.Tokens.Jwt;
////using System.Linq;
////using System.Security.Claims;
////using System.Text;
////using System.Threading.Tasks;

////using Domain.Service.Authuser.Interfaces;



////namespace Domain.Service.Authuser
////{
////    public class AuthUserRepository : IAuthUserRepository
////    {

////        private readonly HireMeNowDbContext _context;
////        private readonly IMapper _mapper;
////        private readonly IConfiguration _configuration;

////        public AuthUserRepository(HireMeNowDbContext context, IMapper mapper, IConfiguration configuration)
////        {
////            _context = context;
////            _mapper = mapper;
////            _configuration = configuration;
////        }

////        //// ✅ Register Job Seeker
////        //public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
////        //   {
////        //        authUser.Role = Enums.Role.JOB_SEEKER;
////        //        await _context.AuthUsers.AddAsync(authUser);
////        //        Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
////        //        await _context.JobSeekers.AddAsync(jobSeeker);
////        //        JobSeekerProfile jp = new();
////        //        jp.Id = Guid.NewGuid();
////        //        jp.JobSeekerId = jobSeeker.Id;
////        //        await _context.JobSeekerProfiles.AddAsync(jp);
////        //        _context.SaveChanges();
////        //        return authUser;
////        //    }

////        // ✅ Register Admin (optional)
////        public async Task<AuthUser> AddAuthUserAdmin(AuthUser authUser)
////        {
////            authUser.Role = Enums.Role.ADMIN;
////            await _context.AuthUsers.AddAsync(authUser);
////            await _context.SaveChangesAsync();
////            return authUser;
////        }

////        // ✅ Common Token Creation for both roles
////        public string? CreateToken(AuthUser user)
////        {
////            if (user == null)
////                throw new ArgumentNullException(nameof(user), "User object cannot be null.");

////            string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;
////            if (string.IsNullOrEmpty(tokenSecret))
////                throw new InvalidOperationException("Token secret is missing or empty in configuration.");

////<<<<<<< HEAD
////            // Assign Connection ID and update status
////=======
////            // Update connection info
////>>>>>>> b675f2f9f5b56abc974a76ee90ba683a593e0e36
////            user.ConnectionId = Guid.NewGuid().ToString();
////            user.OnlineStatus = true;
////            _context.SaveChanges();

////<<<<<<< HEAD
////            var claims = new List<Claim>
////=======
////            List<Claim> claims = new List<Claim>
////>>>>>>> b675f2f9f5b56abc974a76ee90ba683a593e0e36
////            {
////                new Claim(ClaimTypes.Name, user.FirstName ?? string.Empty),
////                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
////                new Claim(ClaimTypes.Sid, user.Id.ToString()),
////                new Claim(ClaimTypes.Role, user.Role.ToString()),
////                new Claim("ConnectionId", user.ConnectionId ?? string.Empty)
////            };

////            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
////            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

////            var token = new JwtSecurityToken(
////                claims: claims,
////                expires: DateTime.Now.AddDays(1),
////                signingCredentials: creds
////            );

////            return new JwtSecurityTokenHandler().WriteToken(token);
////        }
////<<<<<<< HEAD
////=======



////        public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
////        {
////            authUser.Role = Enums.Role.JOB_SEEKER;
////            await _context.AuthUsers.AddAsync(authUser);
////            Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
////            await _context.JobSeekers.AddAsync(jobSeeker);
////            JobSeekerProfile jp = new();
////            jp.Id = Guid.NewGuid();
////            jp.JobSeekerId = jobSeeker.Id;
////            await _context.JobSeekerProfiles.AddAsync(jp);
////            _context.SaveChanges();
////            return authUser;
////        }


////        // Add Auth User for Job Provider
////        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)

////        {
////            authUser.Role = Enums.Role.JOB_PROVIDER;

////            await _context.AuthUsers.AddAsync(authUser);

////            Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
////            await _context.JobSeekers.AddAsync(jobSeeker);
////            JobSeekerProfile jp = new();
////            jp.Id = Guid.NewGuid();
////            jp.JobSeekerId = jobSeeker.Id;
////            await _context.JobSeekerProfiles.AddAsync(jp);
////            _context.SaveChanges();
////            return authUser;
////        }

////        public async Task AddUserAsync(AuthUser user)
////        {
////            await _context.AuthUsers.AddAsync(user);
////            await _context.SaveChangesAsync();
////        }



////>>>>>>> b675f2f9f5b56abc974a76ee90ba683a593e0e36
////    }
////}


>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
//using AutoMapper;
//using Domain.Models;
//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;
//using System;
//using System.Collections.Generic;
<<<<<<< HEAD
//using System.Linq;
=======
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
//using System.Text;
//using System.Threading.Tasks;
//using Domain.Service.Authuser.Interfaces;

<<<<<<< HEAD

//namespace Domain.Service.Authuser
//{
//    internal class AuthUserRepository
//    {

//        private readonly HireMeNowDbContext _context;
//        IMapper _mapper;
//        private readonly IConfiguration _configuration;
=======
//namespace Domain.Service.Authuser
//{
//    public class AuthUserRepository : IAuthUserRepository
//    {
//        private readonly HireMeNowDbContext _context;
//        private readonly IMapper _mapper;
//        private readonly IConfiguration _configuration;

>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
//        public AuthUserRepository(HireMeNowDbContext context, IMapper mapper, IConfiguration configuration)
//        {
//            _context = context;
//            _mapper = mapper;
//            _configuration = configuration;
<<<<<<< HEAD

//        }

=======
//        }

//        // ✅ Register Job Seeker
//        public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
//        {
//            authUser.Role = Enums.Role.JOB_SEEKER;
//            await _context.AuthUsers.AddAsync(authUser);

//            var jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
//            await _context.JobSeekers.AddAsync(jobSeeker);

//            JobSeekerProfile jp = new()
//            {
//                Id = Guid.NewGuid(),
//                JobSeekerId = jobSeeker.Id
//            };

//            await _context.JobSeekerProfiles.AddAsync(jp);
//            await _context.SaveChangesAsync();

//            return authUser;
//        }

//        // ✅ Register Admin
//        public async Task<AuthUser> AddAuthUserAdmin(AuthUser authUser)
//        {
//            authUser.Role = Enums.Role.ADMIN;
//            await _context.AuthUsers.AddAsync(authUser);
//            await _context.SaveChangesAsync();
//            return authUser;
//        }

//        // ✅ Register Job Provider
//        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)
//        {
//            authUser.Role = Enums.Role.JOB_PROVIDER;

//                       await _context.AuthUsers.AddAsync(authUser);

//                        Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
//                        await _context.JobSeekers.AddAsync(jobSeeker);
//                        JobSeekerProfile jp = new();
//                        jp.Id = Guid.NewGuid();
//                        jp.JobSeekerId = jobSeeker.Id;
//                        await _context.JobSeekerProfiles.AddAsync(jp);
//                        _context.SaveChanges();
//                        return authUser;
//        }

//        // ✅ Create Token (for any user)
>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
//        public string? CreateToken(AuthUser user)
//        {
//            if (user == null)
//                throw new ArgumentNullException(nameof(user), "User object cannot be null.");

//            string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;
//            if (string.IsNullOrEmpty(tokenSecret))
//                throw new InvalidOperationException("Token secret is missing or empty in configuration.");

<<<<<<< HEAD
//            // Update connection info
=======
//            // Assign Connection ID and update online status
>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
//            user.ConnectionId = Guid.NewGuid().ToString();
//            user.OnlineStatus = true;
//            _context.SaveChanges();

//            List<Claim> claims = new List<Claim>
//            {
//                new Claim(ClaimTypes.Name, user.FirstName ?? string.Empty),
//                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
//                new Claim(ClaimTypes.Sid, user.Id.ToString()),
//                new Claim(ClaimTypes.Role, user.Role.ToString()),
//                new Claim("ConnectionId", user.ConnectionId ?? string.Empty)
//            };

//            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
//            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

//            var token = new JwtSecurityToken(
//                claims: claims,
//                expires: DateTime.Now.AddDays(1),
//                signingCredentials: creds
//            );

//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }

<<<<<<< HEAD


//        public async Task<AuthUser> AddAuthUserJS(AuthUser authUser)
//        {
//            authUser.Role = Enums.Role.JOB_SEEKER;
//            await _context.AuthUsers.AddAsync(authUser);
//            Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
//            await _context.JobSeekers.AddAsync(jobSeeker);
//            JobSeekerProfile jp = new();
//            jp.Id = Guid.NewGuid();
//            jp.JobSeekerId = jobSeeker.Id;
//            await _context.JobSeekerProfiles.AddAsync(jp);
//            _context.SaveChanges();
//            return authUser;
//        }


//        // Add Auth User for Job Provider
//        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)

//        {
//            authUser.Role = Enums.Role.JOB_PROVIDER;

//            await _context.AuthUsers.AddAsync(authUser);

//            Models.JobSeeker jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
//            await _context.JobSeekers.AddAsync(jobSeeker);
//            JobSeekerProfile jp = new();
//            jp.Id = Guid.NewGuid();
//            jp.JobSeekerId = jobSeeker.Id;
//            await _context.JobSeekerProfiles.AddAsync(jp);
//            _context.SaveChanges();
//            return authUser;
//        }

=======
//        // ✅ Common Add method if needed
>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
//        public async Task AddUserAsync(AuthUser user)
//        {
//            await _context.AuthUsers.AddAsync(user);
//            await _context.SaveChangesAsync();
//        }
<<<<<<< HEAD



//    }
//}

=======
//    }
//}
>>>>>>> 6959ce1bb84d1b7c1ba32b28f827057c8f121f75
using AutoMapper;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Authuser.Interfaces;

namespace Domain.Service.Authuser
{
    public class AuthUserRepository : IAuthUserRepository
    {
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

            var jobSeeker = _mapper.Map<Models.JobSeeker>(authUser);
            await _context.JobSeekers.AddAsync(jobSeeker);

            var jp = new JobSeekerProfile
            {
                Id = Guid.NewGuid(),
                JobSeekerId = jobSeeker.Id
            };

            await _context.JobSeekerProfiles.AddAsync(jp);
            await _context.SaveChangesAsync();

            return authUser;
        }

        // ✅ Register Admin
        public async Task<AuthUser> AddAuthUserAdmin(AuthUser authUser)
        {
            authUser.Role = Enums.Role.ADMIN;
            await _context.AuthUsers.AddAsync(authUser);
            await _context.SaveChangesAsync();
            return authUser;
        }

        // ✅ Register Job Provider
        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)
        {
            authUser.Role = Enums.Role.JOB_PROVIDER;

            await _context.AuthUsers.AddAsync(authUser);

            // Map AuthUser to JobProvider entity (not JobSeeker!)
            var jobProvider = _mapper.Map<JobProviderCompany>(authUser);
            await _context.JobProviderCompanies.AddAsync(jobProvider);

            await _context.SaveChangesAsync();

            return authUser;
        }

        // ✅ Create JWT Token for any user
        public string? CreateToken(AuthUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User object cannot be null.");

            string tokenSecret = _configuration.GetValue<string>("AuthSettings:Token");
            if (string.IsNullOrEmpty(tokenSecret))
                throw new InvalidOperationException("Token secret is missing in configuration.");

            // Assign Connection ID and online status
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

        // ✅ Common Add method
        public async Task AddUserAsync(AuthUser user)
        {
            await _context.AuthUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
