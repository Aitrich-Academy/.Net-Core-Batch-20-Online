using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser.Interfaces;
<<<<<<< HEAD
using Domain.Service.Login.DTO;
=======
using Domain.Service.Login.DTOs;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
using Domain.Service.Login.Interfaces;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        private readonly ILoginRequestRepository _loginRepository;
        private readonly IAuthUserRepository _authUserRepository;
        private readonly IMapper _mapper;

<<<<<<< HEAD
        public LoginRequestService(
            ILoginRequestRepository loginRepository,
            IMapper mapper,
            IAuthUserRepository authUserRepository)
=======
        public LoginRequestService(ILoginRequestRepository loginRepository, IMapper mapper, IAuthUserRepository authUserRepository)
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
        {
            _loginRepository = loginRepository;
            _mapper = mapper;
            _authUserRepository = authUserRepository;
        }

<<<<<<< HEAD
        // ==============================
        // Login Method for JobProvider
        // ==============================
        public JobProviderLoginDto Login(string email, string password)
        {
            var user = _loginRepository.GetUserByEmail(email);
            if (user == null)
                return null;

            // Verify hashed password
            if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
                return null;

            var dto = _mapper.Map<JobProviderLoginDto>(user);
            dto.Token = _authUserRepository.CreateToken(user);

            return dto;
=======
        public async Task<JobSeekerLoginDto?> LoginJS(string email, string password)
        {
            var user = await _loginRepository.GetUserByEmailAndPasswordAsync(email, password);
            if (user == null)
                return null;

            var userDto = _mapper.Map<JobSeekerLoginDto>(user);
            userDto.Token = _authUserRepository.CreateToken(user);
            return userDto;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
        }
    }
}

