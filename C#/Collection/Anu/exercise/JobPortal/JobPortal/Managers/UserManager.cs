using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Enums;
using JobPortal.Exceptions;
using JobPortal.Interfaces;
using JobPortal.Models;


namespace JobPortal.Managers
{
    public  class UserManager
    {
        private List<IUser> users = new List<IUser>();

        public void Register(string username, string password, string fullName, UserRole role)
        {
            if (users.Exists(u => u.Username == username))
                throw new InvalidInputException("Username already exists.");

            IUser user;
            if (role == UserRole.Applicant)
                user = new Applicant { Username = username, Password = password, FullName = fullName, Role = role };
            else
                user = new JobProvider { Username = username, Password = password, FullName = fullName, Role = role };

            users.Add(user);
        }

        public IUser Login(string username, string password)
        {
            var user = users.Find(u => u.Username == username && u.Password == password);
            if (user == null)
                throw new UserNotFoundException("Invalid username or password.");
            return user;
        }
    }

}

