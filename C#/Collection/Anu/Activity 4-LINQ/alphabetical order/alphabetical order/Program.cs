using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetical_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Nasif", Age = 25 },
                new Person { Name = "Alice", Age = 35 },
                new Person { Name = "Zoya", Age = 28 },
                new Person { Name = "Fasna", Age = 22 }
            };

            // Use LINQ to get names in alphabetical order
            var sortedNames = people
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();

            // Output the sorted names
            Console.WriteLine("Names in alphabetical order:");
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine(); // Pause the console
        }
    }
    }

