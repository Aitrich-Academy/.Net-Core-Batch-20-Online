using HospitalPortal.Models;

namespace HospitalPortal.Interfaces
{
    public interface IUserRepository
    {
        void Register(User user);
        User? GetById(int id);
        User? GetByEmail(string email);
        IEnumerable<User> GetAll();
    }
}
