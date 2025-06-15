using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Interfaces;
using NewExcersice.Model;

namespace NewExcersice.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly List<User> _users = new();
       

        public User Login(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

       

        public void Register(User user)
        {
            user.Id = _users.Count + 1;
            
            _users.Add(user);
        }
    }
}
