using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Interface;
using Domain.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
 



namespace Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _contex;
       
        public UserRepository(ApplicationDbContext contex)
        {
            _contex = contex;
           
        }

        public async Task<User> AddRegisterAsync(User user)
        {
           
            var objUser = _contex.users.FirstOrDefault(x => x.Email == user.Email);
            if (objUser == null)
            {
                _contex.users.Add(new Models.User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    Role = user.Role,
                });
                _contex.SaveChanges();
            }
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _contex.users.FirstOrDefaultAsync(u => u.Email == email);
            
        }

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)

        {
            return await _contex.users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        
         
    }
}
