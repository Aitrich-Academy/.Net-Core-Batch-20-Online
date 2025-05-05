using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Models;

namespace Admin.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
