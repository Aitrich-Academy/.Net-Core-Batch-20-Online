using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Interface
{
    public interface IRepository
    {
        public User Login(string email, string password);
        public bool Register(User u);

        public void Myprofile();
        public List<User> ListnewRegistration();
      
        
       
    }
}
