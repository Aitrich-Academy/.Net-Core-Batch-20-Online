using HospitalPortal.Dtos;

namespace HospitalPortal.Interfaces
{
    public interface IUserService
    {
        void Register(UserDto userDto);
        UserDto? GetById(int id);
        UserDto? GetByEmail(string email);
        IEnumerable<UserDto> GetAll();
    }
}
