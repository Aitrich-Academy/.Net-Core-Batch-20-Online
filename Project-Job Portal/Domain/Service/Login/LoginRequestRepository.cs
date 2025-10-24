using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        private readonly HireMeNowDbContext _context;

        public LoginRequestRepository(HireMeNowDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<AuthUser?> GetUserByEmailAsync(string email)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<AuthUser?> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            return await _context.AuthUsers
                .FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
        }
    }
}
