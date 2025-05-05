using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Models;

namespace JobProvider.Interface
{
    internal interface IUserRepository
    {
        List<User> GetAllProvider();
        List<User> GetAllSeeker();
    }
}
