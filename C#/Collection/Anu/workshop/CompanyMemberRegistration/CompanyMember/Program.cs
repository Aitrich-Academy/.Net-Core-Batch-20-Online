
using CompanyMember.Interfaces;
using CompanyMember.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMemberRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new CompanyManager();
            menu.DisplayMenu();
        }
    }
}

