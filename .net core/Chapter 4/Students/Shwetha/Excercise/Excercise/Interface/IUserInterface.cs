using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Model;

namespace Excercise.Interface
{
    internal interface IUserInterface
    {
        public void registerSeeker(User seeker);
        public void registerProvider(User provider);
        public User Login(string email, String password);
        public User getLoggedUser();
        public void show_UserProfile();
    }
}
