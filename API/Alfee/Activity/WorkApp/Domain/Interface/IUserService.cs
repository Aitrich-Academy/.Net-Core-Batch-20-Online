using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dto;

namespace Domain.Interface
{
    public interface IUserService
    {
        Task<UserDto> RegisterAsync(UserDto userDto);
        Task<UserDto> LoginAsync(string email, string password);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);
    }
}
