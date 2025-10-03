using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Service.User.Interface;
using Domain.Service.User.DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Domain.Extension;

namespace Domain.Service.User
{
    internal class RegisterUserRepository : IRegisterUserRepository
    {
        public readonly AppDbContext  _contex;

        public RegisterUserRepository(AppDbContext  context)
        {
            _contex = context;

        }

        public async Task<RegisterUser> AddRegisterUserAsync(RegisterUser  user)
        {

            var objUser = _contex.RegisterUsers.FirstOrDefault(x => x.Email == user.Email);
            if (objUser == null)
            {
                _contex.RegisterUsers.Add(new Models.RegisterUser 
                {
                    UserName=user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Phone=user.Phone,
                    Email = user.Email,
                    Password = user.Password,
                    Role = user.Role,
                });
                _contex.SaveChanges();
            }
            return user;
        }

        public async Task<RegisterUser> GetUserByEmailAsync(string email)
        {
            return await _contex.RegisterUsers.FirstOrDefaultAsync(u => u.Email == email);

        }
    }
}
