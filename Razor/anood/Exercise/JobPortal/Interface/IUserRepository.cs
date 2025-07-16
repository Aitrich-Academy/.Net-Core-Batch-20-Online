using JobPortal.Dto;
using JobPortal.Model;
using JobPortal.Repository;

namespace JobPortal.Interface
{
    public interface  IUserRepository
    {
        public Task AddUserAsync(UserDto userDto);

    }
}
