using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Exceptions;
using Exercise4.Models;

namespace Exercise4.Repository
{
    internal class UserRepository
    {
        public List<User> users= new List<User>();

        int userId = 0;

        public bool Register(User user)
        {
            user.Id = userId;
            userId = userId + 1;
            if (users.Find(e => e.Email == user.Email) == null)
            {

                users.Add(user);

                return true;
            }

            throw new UserAlreadyExistException("User Already Exist");
        }

        public User Login(string email, string password)
        {
            return users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }
    }
}
