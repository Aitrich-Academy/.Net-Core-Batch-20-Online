using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Dto;
using AutoMapper;
using Microsoft.Extensions.Configuration; 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
 

namespace Domain.Service
{
    public class UserService : IUserService
    {

        public readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;
        private readonly IConfiguration configuration;


        public UserService(IUserRepository userRepository, IMapper mapper, IConfiguration _configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            configuration = _configuration;
        }

        public async Task<UserDto> AddRegisterAsync(UserDto userdto)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(userdto.Email);
            if (existingUser != null)
                throw new Exception("User with this email already exists.");

            var adduser = _mapper.Map<User>(userdto);
            adduser = await _userRepository.AddRegisterAsync(adduser);
            return _mapper.Map<UserDto>(adduser);
        }
 

        public async Task<(string Token, User User)?> LoginUserAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetUserByEmailAndPasswordAsync(loginDto.Email, loginDto.Password);
            if (user == null) return null;

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, configuration["JWT:Subject"]),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("UserId", user.UserId.ToString()),
            new Claim("Email", user.Email),
            new Claim(ClaimTypes.Role, user.Role.ToString())
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                configuration["JWT:Issuer"],
                configuration["JWT:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: signIn
            );

            string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
            return (tokenValue, user);
        }
    }
}    


