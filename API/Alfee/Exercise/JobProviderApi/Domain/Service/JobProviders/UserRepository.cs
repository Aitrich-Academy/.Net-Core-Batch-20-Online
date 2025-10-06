using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Service.JobProviders.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.JobProviders
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<JobProvider?> GetByEmailAsync(string email)
        {
            return await _context.JobProviders.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task RegisterAsync(JobProvider user)
        {
            _context.JobProviders.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
