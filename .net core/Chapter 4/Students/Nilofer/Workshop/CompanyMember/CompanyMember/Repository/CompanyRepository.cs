using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Interfaces;
using CompanyMember.Models;
using CompanyMember.Exceptions;

namespace CompanyMember.Repository
{
    internal class CompanyRepository : ICompanyRepository
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
