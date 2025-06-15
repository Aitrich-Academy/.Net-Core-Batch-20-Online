using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Model;

namespace CompanyMember.Interfaces
{
    public interface IUserRepository
    {

        bool register(Company company);

    }
}
