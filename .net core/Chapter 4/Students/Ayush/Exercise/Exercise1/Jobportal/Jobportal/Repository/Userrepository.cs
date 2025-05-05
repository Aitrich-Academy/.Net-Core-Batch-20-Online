using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Enums;
using Jobportal.Exceptions;
using Jobportal.Interfaces;
using Jobportal.Models;

namespace Jobportal.Repository
{
    public class Userrepository : IUserrepository
    {
        public Userrepository() { }

        private List<User> users = new List<User>()
        { new User("admin","","admin@gmail.com","123",12345,Role.Admin)

        };

        private User loggeduser;




        public void register(User newuser)
        {
            if (users.Any(e => e.Email == newuser.Email))
            {
                throw new UserAlreadyexist(newuser.Email);
            }

            newuser.Id = users.Count + 1;
            newuser.roles = Role.Seeker;
            users.Add(newuser);

        }

        public List<User> Getall()
        {
            return users.FindAll(e => e.roles == Role.Seeker);
        }

        public User login(string email, string password)
        {
            var User = users.Find(e => e.Email == email && e.Password == password);
            if (User != null)
            {
                loggeduser = User;
            }
            return User;
        }

        public User getloggeduser()
        {
            return loggeduser;
        }

    }
}
