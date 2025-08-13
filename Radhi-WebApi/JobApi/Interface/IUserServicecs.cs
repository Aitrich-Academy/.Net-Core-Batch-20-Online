using JobApi.Model;
using JobPortalAPI.DTOs;

namespace JobApi.Interface
{
    public interface IUserServicecs
    {
        Task<UserDTO> RegisterUserAsync(UserRegisterDTO userRegisterDto);
        Task<UserDTO> LoginUserAsync(UserLoginDTO userLoginDto);
        Task<UserDTO> GetUserByIdAsync(int id);
    }
}
