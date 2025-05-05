

using Admin_Job.Manager;
using JobProvider.Enums;
using JobProvider.Exceptions;
using JobProvider.Interface;
using JobProvider.Models;
using JobProvider.Repository;
using System.Text.RegularExpressions;

namespace JobProvider.Manager
{
    public class PublicManager : IMenu
    {
        private User loggedUser;

        public PublicManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public PublicManager()
        {

        }

        public void DisplayMenu()
        {
            
        }
    }
}
