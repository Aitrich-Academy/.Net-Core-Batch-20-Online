using Exercise.Enum;
using Exercise.Exceptions;
using Exercise.Interface;
using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public class UserRepository : IRepository
    {
        static List<User> users = new List<User>()
        {
            new User(  "Admin","Admin", "Admin@gmail.com", 951324687, "11", Roles.Admin)
        };

        User loggedUser;

        
        public bool Register(User u)
        {
           
            u.roles = Roles.JobSeeker;
            if(users.Find(e=> e.Email == u.Email) == null)
            {
                users.Add(u);
                return true;

            }
            else
            {
                throw new UserException(u.Email);
                return false;
            }
            

        }
        public User Login(string email,string password)
        {
            var loggedUser = users.Where(e => e.Email == email && e.Password == password).FirstOrDefault();
            return loggedUser;
            


        }

       

        public List<User> ListnewRegistration()
        { 
                
                  var Users = users.Where(e => e.roles == Roles.JobSeeker).ToList();
                    return Users;
               

           
        }
       public void Myprofile()
        {
            foreach (var user in users)
            {
                Console.WriteLine("Your Profile:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.Phone);
                Console.WriteLine(user.Email);

            }
        }
    }
}
