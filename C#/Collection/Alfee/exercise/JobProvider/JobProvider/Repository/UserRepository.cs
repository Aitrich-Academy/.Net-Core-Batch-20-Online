using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Models;
using JobSeeker.Exceptions;

namespace JobProvider.Repository
{
    internal class UserRepository
    {
        private List<User> users = new List<User>();
        private int nextId = 1;


        public List<User> getAll()
        {
            return users.ToList();
        }
        public bool register(User user)
        {
            user.Id = nextId;
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
