using AutoMapper;
using JobSeekerPortal.Dtos;
using JobSeekerPortal.Interfaces;
using JobSeekerPortal.Models;

namespace JobSeekerPortal.Service
{
    public class PublicService : IPublicService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public PublicService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public async Task<UserDto?> LoginAsync(string email, string password)
        {
            var user = await _userRepo.GetByEmailAsync(email);
            if (user != null && user.Password == password) // Simple password check
            {
                return _mapper.Map<UserDto>(user);
            }
            return null;
        }

        public async Task<UserDto?> RegisterAsync(UserDto userDto, string password)
        {
            var existingUser = await _userRepo.GetByEmailAsync(userDto.Email);
            if (existingUser != null)
                return null; // Email already exists

            var user = _mapper.Map<User>(userDto);
            user.Password = password; // In real app, hash the password

            await _userRepo.AddAsync(user);
            await _userRepo.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }
    }
}
