
using AutoMapper;
using Domain.Models;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTO;
using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using AutoMapper;
using Domain.Service.Authuser;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Domain.Service.Login
{
    //public class LoginRequestService : ILoginRequestService
    //{
    //    private readonly ILoginRequestRepository _loginRepository;
    //    private readonly IAuthUserRepository _authUserRepository;
    //    private readonly IMapper _mapper;

    //    public LoginRequestService(ILoginRequestRepository loginRepository, IMapper mapper, IAuthUserRepository authUserRepository)
    //    {
    //        _loginRepository = loginRepository;
    //        _mapper = mapper;
    //        _authUserRepository = authUserRepository;
    //    }
    public class LoginRequestService : ILoginRequestService
    {

        private readonly HireMeNowDbContext _context;
        ILoginRequestRepository loginRepository;
        IMapper mapper;
        IAuthUserRepository authUserRepository;
        public LoginRequestService(ILoginRequestRepository _loginRepository, IMapper mapper, IAuthUserRepository _authUserRepository, HireMeNowDbContext context)
        {
            this.loginRepository = _loginRepository;
            this.mapper = mapper;
            authUserRepository = _authUserRepository;
            _context = context;

        }

        //public AdminLoginDTO Adminlogin(string email, string password)
        //{
        //    var user = loginRepository.GetUserByEmail(email);
        //    if (user == null)
        //        return null;

        //    if (password == user.Password)
        //    {
        //        var userReturn = mapper.Map<AdminLoginDTO>(user);
        //        userReturn.Token = authUserRepository.CreateToken(user);
        //        return userReturn;
        //    }

        //    return null;
        //}
        public async Task<AdminLoginDTO?> AdminLoginAsync(string email, string password)
        {
            var user = await loginRepository.GetUserByEmailAsync(email);

            if (user == null || user.Password != password)
                return null;

            var userReturn = mapper.Map<AdminLoginDTO>(user);
            userReturn.Token = authUserRepository.CreateToken(user);

            return userReturn;


        }

        public async Task<bool> LogoutAsync(Guid adminId)
        {
            var user = await _context.AuthUsers.FindAsync(adminId);
            if (user == null)
                return false;

            user.OnlineStatus = false;
            // 0 means offline
            user.ConnectionId = null; // clear connection if any
            await _context.SaveChangesAsync();
            return true;
        }
        //public JobProviderLoginDto Login(string email, string password)
        //{
        //    var user = loginRepository.GetUserByEmailAsync(email);
        //    if (user == null)
        //        return null;

        //    // Verify hashed password
        //    //if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
        //    //    return null;

        //    var dto = mapper.Map<JobProviderLoginDto>(user);
        //    dto.JobProviderId = user.JobProviderId;
        //    dto.Token = authUserRepository.CreateToken(user);
        //    dto.Token = authUserRepository.CreateToken(user);

        //    return dto;

        //    return dto;
        //}

        public async Task<JobProviderLoginDto?> Login(string email, string password)
        {
            // Get the user by email
            var user = await loginRepository.GetUserByEmailAsync(email);

            if (user == null || user.Role != Enums.Role.JOB_PROVIDER)
                return null; // Not found or not a Job Provider

           // Verify password(if using hashed passwords)
             if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
                return null;

            // Generate JWT token
            var token = authUserRepository.CreateToken(user);

            // Map to JobProvider DTO
            var dto = mapper.Map<JobProviderLoginDto>(user);
            dto.JobProviderId = user.JobProviderId;
            dto.Token = token;

            return dto;
        }


        public async Task<JobSeekerLoginDto?> LoginJS(string email, string password)
        {
            var user = await loginRepository.GetUserByEmailAndPasswordAsync(email, password);
            if (user == null)
                return null;

            var userDto = mapper.Map<JobSeekerLoginDto>(user);
            userDto.Token = authUserRepository.CreateToken(user);
            return userDto;
        }
    }
}
