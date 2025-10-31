using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
