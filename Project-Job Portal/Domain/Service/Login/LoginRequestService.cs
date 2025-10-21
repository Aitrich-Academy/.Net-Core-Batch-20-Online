using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        ILoginRequestRepository loginRepository;
        IMapper mapper;
        IAuthUserRepository authUserRepository;
        public LoginRequestService(ILoginRequestRepository _loginRepository, IMapper mapper, IAuthUserRepository _authUserRepository)
        {
            this.loginRepository = _loginRepository;
            this.mapper = mapper;
            authUserRepository = _authUserRepository;



        }

        public async Task<AdminLoginDTO?> AdminLoginAsync(string email, string password)
        {
            var user = await loginRepository.GetUserByEmailAsync(email);

            if (user == null || user.Password != password)
                return null;

            var userReturn = mapper.Map<AdminLoginDTO>(user);
            userReturn.Token = authUserRepository.CreateToken(user);

            return userReturn;


        }






    }
}
