using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Interface
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(User user);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
