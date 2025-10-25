
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

namespace Domain.Service.Login
{
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

        public AdminLoginDTO Adminlogin(string email, string password)
        {
            var user = loginRepository.GetUserByEmail(email);
            if (user == null)
                return null;

            if (password == user.Password)
            {
                var userReturn = mapper.Map<AdminLoginDTO>(user);
                userReturn.Token = authUserRepository.CreateToken(user);
                return userReturn;
            }

            return null;
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


    }
}
