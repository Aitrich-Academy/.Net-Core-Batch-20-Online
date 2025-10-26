using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Login.Interfaces;

namespace Domain.Service.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        private readonly HireMeNowDbContext _context;

        public LoginRequestRepository(HireMeNowDbContext dbContext)
        {
            _context = dbContext;
        }
        public AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers
                .FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
            return user;
        }
    }
}
