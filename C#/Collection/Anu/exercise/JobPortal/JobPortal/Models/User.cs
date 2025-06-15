using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Enums;
using JobPortal.Interfaces;

namespace JobPortal.Models
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public UserRole Role { get; set; }
    }
}
