using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Enums;

namespace JobPortal.Interfaces
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        UserRole Role { get; set; }
    }
}
