using AutoMapper;
using CompanyManagement.Dto;
using CompanyManagement.Interface;
using CompanyManagement.Model;

namespace CompanyManagement.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<bool> RegisterUserAsync(UserDto userDto)
        {
            var existingUser = await _userRepository.GetByUsernameAsync(userDto.Username);
            if (existingUser != null)
                return false;

            var user = _mapper.Map<User>(userDto); 
            return await _userRepository.AddUserAsync(user);
        }

        public async Task<User?> LoginUserAsync(UserDto userDto)
        {
            return await _userRepository.ValidateUserAsync(userDto.Username, userDto.Password);
        }
    }
}
