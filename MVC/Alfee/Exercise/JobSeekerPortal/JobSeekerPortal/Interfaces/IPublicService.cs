using JobSeekerPortal.Dtos;

namespace JobSeekerPortal.Interfaces
{
    public interface IPublicService
    {
        Task<UserDto?> RegisterAsync(UserDto userDto, string password);
        Task<UserDto?> LoginAsync(string email, string password);
    }
}
