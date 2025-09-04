using JobPortalAPI.DTO;

namespace JobPortalAPI.Interface
{
    public interface IUserService
    {
        Task<UserDto> RegisterUserAsync(UserDto userDto);

        Task<UserDto> GetUserByIdAsync(int id);

        Task<UserDto> LoginUserAsync(UserLoginDto userLoginDto);
    }
}
