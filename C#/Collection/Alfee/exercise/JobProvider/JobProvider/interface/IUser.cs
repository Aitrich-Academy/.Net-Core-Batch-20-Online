using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Interfaces
{
    interface IUser
    {
        List<IUser> getAll();
        bool register(IUser user);
    }
}
