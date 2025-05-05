using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Models;
namespace JobProvider
{
    internal class Lists
    {
       public void Print( List<User> providers)
        {
            Console.WriteLine("Registraions \n");
            Console.WriteLine("{0, -10} | {1, -20} | {2, -30 } | {3, -20} | {4, -20} | {5, -20}", "Id", "FirstName", "LastName", "Email", "Password", "PhoneNumber");
            if (providers != null)
            {
                foreach (var provider in providers)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -30 } | {3, -20} | {4, -20} | {5, -20}", provider.Id, provider.FirstName, provider.LastName, provider.Email, provider.Password, provider.PhoneNumber);
                }
          
            Console.WriteLine("\n");
            }
        }
        public void Print( List<Job> jobs) {
            Console.WriteLine("Jobs : \n");
            Console.WriteLine("{0, -10} | {1, -20} | {2, -30 } | {3, -20} | {4, -20} | {5, -20} | {6, -20}", "Id", "Title", "Description", "Location", "Type", "Salary", "Company");
            if (jobs != null)
            
                foreach (Job job in jobs)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -30 } | {3, -20} | {4, -20} | {5, -20} | {6, -20}", job.Id, job.Title, job.Description, job.Location, job.Type, job.Salary, job.Company);
                }

                Console.WriteLine("\n");
            }
            }

    }

