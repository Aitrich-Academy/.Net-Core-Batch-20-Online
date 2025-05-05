using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Enums;
using Excercise.Interface;
using Excercise.Manager;
using Excercise.Model;

namespace Excercise.Repository
{
    public class UserRepository : IUserInterface
    {
        
       static List<User> Users = new List<User>()    
        {
        new User("Alice", "alice123@gmail.com", "1234", 9876543210, Roles.JobSeeker),
        new User("Bob", "bob123@gmail.com", "1234", 9876543210, Roles.Jobprovider)
        };
        static User loggedUser;
        public void registerSeeker(User seekerUsers)
        {
            seekerUsers.roles = Roles.JobSeeker;
            var query = Users.Where(e => e.Email == seekerUsers.Email).FirstOrDefault();

        }
        public void registerProvider(User providerUsers)
        {
            providerUsers.roles = Roles.Jobprovider;
            var query = Users.Where(e => e.Email == providerUsers.Email).FirstOrDefault();
        }
        public User Login(string email , String password)
        {
            var loggedUser = Users.Where(e => e.Email == email && e.Password== password).FirstOrDefault();
            return loggedUser;
        }
        public User getLoggedUser()
        {
            return loggedUser;
        }
        public void show_UserProfile()
        {
            foreach (var user in Users)
            {
                Console.WriteLine(user.Id);
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Password);

            }
        }

    }
}
