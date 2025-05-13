internal class Program
{
   public class Person
   {
     public string Name { get; set; }
     public int Age { get; set; }

   }
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person {Name = "Alfee", Age = 25},
            new Person {Name = "Remya", Age = 40},
            new Person {Name = "Ajmal", Age = 32},
            new Person {Name = "Radhi", Age = 35},
        };

        var result = from person in people
                     where person.Name.StartsWith("A")
                     select person;
        foreach(var p in result)
        {
            Console.WriteLine($"{p.Name}, Age: {p.Age}");
        }

    }
}