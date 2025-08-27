using AutoMapper;
using JobSeekerPortal.Dtos;
using JobSeekerPortal.Interfaces;
using JobSeekerPortal.Models;

namespace JobSeekerPortal.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public async Task<UserDto> RegisterUserAsync(UserDto userDto, string password)
        {
            var user = _mapper.Map<User>(userDto);
            user.Password = password; // In real app, hash the password

            await _userRepo.AddAsync(user);
            await _userRepo.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<UserDto?> GetByEmailAsync(string email)
        {
            var user = await _userRepo.GetByEmailAsync(email);
            return _mapper.Map<UserDto?>(user);
        }

        public async Task<UserDto?> GetByIdAsync(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            return _mapper.Map<UserDto?>(user);
        }

        public async Task UpdateUserAsync(UserDto userDto)
        {
            var user = await _userRepo.GetByIdAsync(userDto.Id);
            if (user != null)
            {
                _mapper.Map(userDto, user);
                _userRepo.Update(user);
                await _userRepo.SaveChangesAsync();
            }
        }
    }
}
