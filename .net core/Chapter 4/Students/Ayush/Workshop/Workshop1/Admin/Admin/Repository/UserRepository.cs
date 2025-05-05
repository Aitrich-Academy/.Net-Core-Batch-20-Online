using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Enums;
using Admin.Interfaces;
using Admin.Models;

namespace Admin.Repository
{
    public sealed class UserRepository : IUserRepository
    {
        private List<User> users = new List<User> { new User(1,"admin","","admin@gmail.com","123",123,Roles.Admin), new User(2,"admin2","","admin1@gmail.com","123",123445,Roles.Admin)};

        private static User loggeduser = new User();
        


        public List<User> GetAll()
        {
            return users.Where(e=>e.Roles==Roles.Admin).ToList();
        }

        public User login(string email, string password)
        {
            var user= users.FirstOrDefault(e=>e.Email==email && e.Password==password);
            if (user!= null)
            {
                loggeduser=user;
            }
            return user;
        }

        public User getloggeduser()
        {   
            return loggeduser;
        }
        
    }
}
