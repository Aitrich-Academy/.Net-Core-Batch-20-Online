using AutoMapper;
using HospitalPortal.Dtos;
using HospitalPortal.Interfaces;
using HospitalPortal.Models;

namespace HospitalPortal.Service
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

        public void Register(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _userRepo.Register(user);
        }

        public UserDto? GetById(int id)
        {
            var user = _userRepo.GetById(id);
            return _mapper.Map<UserDto>(user);
        }

        public UserDto? GetByEmail(string email)
        {
            var user = _userRepo.GetByEmail(email);
            return _mapper.Map<UserDto>(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = _userRepo.GetAll();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
