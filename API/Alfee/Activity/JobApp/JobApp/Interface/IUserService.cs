using JobApp.Dto;

namespace JobApp.Interface
{
    public interface IUserService
    {
        Task<UserDto> RegisterUserAsync(UserRegisterDto userRegisterDto);
        Task<UserDto> LoginUserAsync(UserLoginDto userLoginDto);
        Task<UserDto> GetUserByIdAsync(int id);
    }
}
