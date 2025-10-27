using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Login.Interfaces;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341

namespace Domain.Service.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        private readonly HireMeNowDbContext _context;

        public LoginRequestRepository(HireMeNowDbContext dbContext)
        {
            _context = dbContext;
        }
<<<<<<< HEAD
        public AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers
                .FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
            return user;
=======

        public async Task<AuthUser?> GetUserByEmailAsync(string email)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<AuthUser?> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            return await _context.AuthUsers
                .FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
        }
    }
}
