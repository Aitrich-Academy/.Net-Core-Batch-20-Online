using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Models;

namespace CompanyMember.Interfaces
{
    internal interface ICompanyRepository
    {
        bool Register(Company company);
        List<Company> ListCompanies();
    }
}
