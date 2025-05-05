using JobProviderModule.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderModule.Manager
{
    public class UserManager : IMenu
    {
        private User loggedUser;

        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public UserManager()
        {

        }

        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
