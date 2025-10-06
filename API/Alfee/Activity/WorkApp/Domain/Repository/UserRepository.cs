using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetByEmailAsync(string email)
            => await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

        public async Task<User> GetByIdAsync(int id)
            => await _context.Users.FindAsync(id);

        public async Task<IEnumerable<User>> GetAllAsync()
            => await _context.Users.ToListAsync();
    }
}
