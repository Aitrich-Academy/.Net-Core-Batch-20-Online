using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.User.Interface;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Service.User.DTO;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Internal;

namespace Domain.Service.User
{
    public class RegisterUserService : IRegisterUserService 
    {

        public readonly IRegisterUserRepository  _userRepository;
        public readonly IMapper _mapper;
        private readonly IConfiguration configuration;


        public RegisterUserService(IRegisterUserRepository userRepository, IMapper mapper, IConfiguration _configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            configuration = _configuration;
        }

        public async Task<RegisterUserDto> AddRegisterUserAsync(RegisterUserDto ReguserDto)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(ReguserDto.Email);
            if (existingUser != null)
                throw new Exception("User with this email already exists.");

            var adduser = _mapper.Map<RegisterUser>(ReguserDto);
            adduser = await _userRepository.AddRegisterUserAsync(adduser);
            return _mapper.Map<RegisterUserDto>(adduser);
        }
    }
}
