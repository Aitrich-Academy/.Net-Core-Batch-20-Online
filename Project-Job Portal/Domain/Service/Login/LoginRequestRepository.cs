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
        public LoginRequestRepository(HireMeNowDbContext context)
        {
            _context = context;

        }

       

        public async Task<AuthUser?> GetUserByEmailAsync(string email)
        {
            return await _context.AuthUsers
                .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
        }


    }
}
