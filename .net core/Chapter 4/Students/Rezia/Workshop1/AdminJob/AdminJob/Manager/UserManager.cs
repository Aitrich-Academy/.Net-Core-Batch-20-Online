using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminJob.Models;
using AdminJob.Interface;

namespace AdminJob.Manager
{
    internal class UserManager : IMenu
    {
        public User loggedUser;
        public UserManager(User loggeduser) 
        { 
            this.loggedUser = loggeduser;   
        }    
        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
