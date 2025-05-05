using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminJob.Enums;
using AdminJob.Exceptions;
using AdminJob.Models;
using AdminJob.Manager;
using AdminJob.Interface;

namespace AdminJob.Repository
{
    internal class UserRepository : IUserRepository
    {
       
        private List<User> users = new List<User>()
        {
            new User(1,"admin","IT","adminit@abcd.com",1234567890,"adminit",Roles.Admin),
            new User(2,"admin","HR","adminhr@abcd.com",0987654321,"adminhr",Roles.Admin),
            new User(3,"admin","Finance","adminfin@abcd.com",1234567899,"adminfin",Roles.Admin)
        };
        private User loggedUser = new User();

        public List<User> GetUsers()
        {
            return users.Where(e => e.Role == Roles.Admin).ToList();
        }
        public User login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(e => e.Email == email && e.Password == password);
            return loggedUser;
        }
        public User GetLoggedUser()
        {
            return loggedUser;


        }
    }
}

