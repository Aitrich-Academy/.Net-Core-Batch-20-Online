using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Exceptions;
using Exercise4.Models;

namespace Exercise4.Repository
{
    internal class CompanyRepository
    {
        private int nextId = 0;
        private List<Company> Companies = new List<Company>();

        public bool Register(Company company)
        {
            company.Id = nextId;
            nextId++;

            if (Companies.Find(e => e.Email == company.Email) == null)
            {
                Companies.Add(company);
                return true;
            }
            throw new UserAlreadyExistException(company.Email);
        }

        public List<Company> ListCompanies()
        {
            return Companies;
        }
    }
}
