using JobSeekerPortal.Dtos;

namespace JobSeekerPortal.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> GetByIdAsync(int id);
        Task<UserDto?> GetByEmailAsync(string email);
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto> RegisterUserAsync(UserDto userDto, string password);
        Task UpdateUserAsync(UserDto userDto);
    }
}
