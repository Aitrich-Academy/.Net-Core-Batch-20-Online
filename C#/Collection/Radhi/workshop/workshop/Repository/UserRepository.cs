using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Enum;
using workshop.Exceptions;
using workshop.Model;

namespace workshop.Repository
{
    public class UserRepository
    {
        private List<User> users = new List<User>()
        {
             new User(2, "Lal", "Krishna", "lalkrishna@gmail.com", 123, "123", Roles.jobprovider), new User(2, "Raj", "Ram", "jobProvider@gmail.com", 123, "123", Roles.jobprovider)
        };
        private int nextId = 3;


        public List<User> getAll()
        {
            return users.Where(e => e.Role == Roles.jobseeker).ToList();
        }
        public bool register(User user)
        {
            user.Id = nextId;
            user.Role = Roles.jobprovider ;
            nextId++;
            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistException(user.Email);
        }
        public User login(string email, string password)
        {
            return users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }
    }

}

