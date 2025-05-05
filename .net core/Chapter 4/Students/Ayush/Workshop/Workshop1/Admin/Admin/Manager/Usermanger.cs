using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Interfaces;
using Admin.Models;

namespace Admin.Manager
{
    public class Usermanger : IMenu
    {


        public Usermanger() { }

        private User loggeduser;

        public Usermanger(User loggeduser)
        {
            this.loggeduser = loggeduser;
        }

        public void Displaymenu()
        {
            throw new NotImplementedException();
        }
  
        
    }
}
