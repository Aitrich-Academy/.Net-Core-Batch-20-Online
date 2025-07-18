using JobPortal.Dto;
using JobPortal.Model;
using JobPortal.Repository;

namespace JobPortal.Interface
{
    public interface  IUserService
    {
        public Task AddUserAsync(UserDto userDto);
    }
}
