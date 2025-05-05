using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_oldest_person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 45 },
                new Person { Name = "Charlie", Age = 40 },
                new Person { Name = "Diana", Age = 50 }
            };

            // Use LINQ to find the oldest person
            Person oldest = people.OrderByDescending(p => p.Age).FirstOrDefault();

            if (oldest != null)
            {
                Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");
            }
            else
            {
                Console.WriteLine("No people in the list.");
            }

            Console.ReadLine();
        }
    }
    }

