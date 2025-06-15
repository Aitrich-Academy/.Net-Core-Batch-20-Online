using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Model;

namespace workshop.Interfaces
{
    public interface ICompanyRepository
    {
        bool register(Company company);
        List<Company> ListCompanies();
    }
}
