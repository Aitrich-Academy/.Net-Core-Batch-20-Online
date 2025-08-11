using SimpleAuthMVC.Dto;

namespace SimpleAuthMVC.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterDto registerDto);
        Task<UserDto> LoginAsync(LoginDto loginDto);
    }
}
