using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminJob.Models;

namespace AdminJob
{
    internal class Lists
    {
        public void Print(List<User> Admins)
        {
            Console.WriteLine("Registrations \n");
            Console.WriteLine("{0,-10} | {1, -20} | {2, -20} | {3, -20} | {4, -20}", "Id", "FirstName", "LastName", "Phone", "Email");
            if (Admins != null)
            {
                foreach (User item in Admins)
                {
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine("{0,-10} | {1, -20} | {2, -20} | {3, -20} | {4, -20}", item.Id, item.FirstName, item.LastName, item.Phone, item.Email);
                    Console.WriteLine();
                }

            }
        }
        public void Print(List<Job> job)
        {
            Console.WriteLine("Registration \n");
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4, -20} | {5, -20} | {6, -20}", "Id", "Title", "Description", "Location", "Salary", "Type", "Company");
            if (job != null)
            {
                foreach (Job jobss in job)
                {
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -20}, {3, -20} | {4, -20} | {5, -20} | {6, -20}", jobss.Id, jobss.Title, jobss.Description, jobss.Location, jobss.Salary, jobss.Type, jobss.Company);
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }

        }
    }
}
