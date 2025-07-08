using CompanyManagement.Dto;
using CompanyManagement.Model;

namespace CompanyManagement.Interface
{
        public interface IUserService
        {
            Task<bool> RegisterUserAsync(UserDto userDto);         
            Task<User?> LoginUserAsync(UserDto userDto);
        }
    
}
