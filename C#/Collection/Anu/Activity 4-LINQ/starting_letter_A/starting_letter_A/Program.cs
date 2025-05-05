using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starting_letter_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Andrew", Age = 40 },
                new Person { Name = "Charlie", Age = 22 },
                new Person { Name = "Amanda", Age = 28 }
            };

            // LINQ query to find people whose names start with 'A'
            var peopleWithA = people
                .Where(p => p.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Display results
            Console.WriteLine("People whose names start with 'A':");
            foreach (var person in peopleWithA)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }

            Console.ReadLine(); // Keeps the console open
        }
    }
    }

