using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        private readonly ILoginRequestRepository _loginRepository;
        private readonly IAuthUserRepository _authUserRepository;
        private readonly IMapper _mapper;

        public LoginRequestService(ILoginRequestRepository loginRepository, IMapper mapper, IAuthUserRepository authUserRepository)
        {
            _loginRepository = loginRepository;
            _mapper = mapper;
            _authUserRepository = authUserRepository;
        }

        public async Task<JobSeekerLoginDto?> LoginJS(string email, string password)
        {
            var user = await _loginRepository.GetUserByEmailAndPasswordAsync(email, password);
            if (user == null)
                return null;

            var userDto = _mapper.Map<JobSeekerLoginDto>(user);
            userDto.Token = _authUserRepository.CreateToken(user);
            return userDto;
        }
    }
}
