using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagement.Dto;
using UserManagement.Interface;
using UserManagement.Models;

namespace UserManagement.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<User>> GetAllUserAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddUserAsync(UserDto userdto)
        {
            var user = _mapper.Map<User>(userdto);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }


        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
        }
    }
}

