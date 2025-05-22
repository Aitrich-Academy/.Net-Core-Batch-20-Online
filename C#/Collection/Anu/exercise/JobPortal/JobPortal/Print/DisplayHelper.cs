using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Print
{
    public static class DisplayHelper
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register (Job Provider / Applicant)");
            Console.WriteLine("3. Exit");
        }

        public static void ShowJobProviderMenu(string name)
        {
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine("1. Jobs");
            Console.WriteLine("2. Applications");
            Console.WriteLine("3. Interviews");
            Console.WriteLine("4. Exit");
        }

        public static void ShowApplicantMenu(string name)
        {
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine("1. List All Jobs");
            Console.WriteLine("2. Saved Jobs");
            Console.WriteLine("3. Applied Jobs");
            Console.WriteLine("4. My Profile");
            Console.WriteLine("5. Exit");

        }
    }
}
