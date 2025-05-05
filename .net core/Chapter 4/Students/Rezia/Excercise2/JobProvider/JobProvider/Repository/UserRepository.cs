using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Interface;
using JobProvider.Models;
using JobProvider.Enums;
using JobProvider.Exceptions;

namespace JobProvider.Repository
{
    internal  class UserRepository : IUserRepository
    {
      private  List<User> users = new List<User>()
        {
            new User(1,"JobProvider","IT","providerit@abcd.com","proit",1234567890,Roles.JobProvider),
            new User(2,"JobProvider","HR","providerhr@abcd.com","prohr",9876543210,Roles.JobProvider),
            new User(3,"JobProvider","Finance","providerfin@abcd.com","profin",1239874560,Roles.JobProvider),
            new User(1,"JobSeeker","IT","seekerit@abcd.com","seekit",1234567890,Roles.JobSeeker),
            new User(2,"JobSeeker","HR","seekerhr@abcd.com","seekhr",9876543210,Roles.JobSeeker),
            new User(3,"JobSeeker","Finance","seekerfin@abcd.com","seekfin",1239874560,Roles.JobSeeker)
        };
        public static User loggedUser = new User();
        private int nextid = 1;

        public List<User> GetAllProvider()
        {
            return users.Where(e => e.Role == Roles.JobProvider).ToList();
        }
        public User Login(string email, string password)
        {
            return users.FirstOrDefault(a => a.Email == email && a.Password == password);
        }
        public bool register(User user)
        {
            user.Id = nextid;
            user.Role = Roles.JobProvider;
            nextid++;

            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExitsException(user.Email);

        }
        public List<User> GetAllSeeker()
        {
            return users.Where(s => s.Role == Roles.JobSeeker).ToList();
        }
        public bool Registerseeker(User user)
        {
            user.Id = nextid;
            user.Role = Roles.JobSeeker;
            nextid++;

            if (users.Find(s => s.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExitsException(user.Email);

        }
    }
}
