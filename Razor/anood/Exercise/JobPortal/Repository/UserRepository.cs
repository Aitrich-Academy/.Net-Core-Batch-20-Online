using AutoMapper;
using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Interface;
using JobPortal.Model;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddUserAsync(UserDto userDto)
        {
            var myuser = _mapper.Map<User>(userDto);
            _context.Users.Add(myuser);
            await _context.SaveChangesAsync();
        }
    }
}
