using System;
using System.Collections.Generic;
using System.Xml.Linq;
using linqr;

public class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Anna", Age = 22 },
            new Person { Name = "John", Age = 28 }
        };

        var peopleStartingWithA = people
            .Where(p => p.Name.StartsWith("A"))
            .ToList();

        foreach (var person in peopleStartingWithA)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }

        var oldestPerson = people.OrderByDescending(p => p.Age).FirstOrDefault();

        // display the oldest person.
        if (oldestPerson != null)
        {
            Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}");
        }
        else
        {
            Console.WriteLine("No people found.");
        }
      //  Make a list of people with name and age.Use LINQ to get all names in alphabetical order

        var sortedNames = people
            .Select(p => p.Name)
            .OrderBy(name => name);

        Console.WriteLine("Names in alphabetical order:");
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }

    }

}
