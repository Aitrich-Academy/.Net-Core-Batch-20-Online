using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Models;
using CompanyMember.Enums;
using CompanyMember.Exceptions;

namespace CompanyMember.Repository
{
    internal class UserRepository
    {
        private List<User> users = new List<User>()
        {
            new User(1,"Anu","Joseph","anu@gmail.com",123,"abc",Roles.Jobprovider),
            new User(2,"lal","krishna","lal@gmail.com",456,"def",Roles.Jobprovider)
        };

        private int nextId = 3;

        public List<User> GetAll()
        {
            return users.Where(e => e.Role == Roles.Jobprovider).ToList();
        }

        public bool register(User user)
        {
            user.Id = nextId;
            user.Role = Roles.Jobprovider;
            nextId++;
            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistException(user.Email);
        }
        public User Login(string email, string password)
        {
            return users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }


    }
}
