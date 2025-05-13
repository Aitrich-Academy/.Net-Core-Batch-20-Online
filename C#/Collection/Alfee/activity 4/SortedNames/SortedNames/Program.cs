internal class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Sasha", Age = 30 },
            new Person { Name = "Jean", Age = 25 },
            new Person { Name = "Levi", Age = 40 },
            new Person { Name = "Erwin", Age = 35 }
        };

        var sortedNames = from person in people
                          orderby person.Name
                          select person.Name;
        Console.WriteLine("Name in Alphabetical order:");
        foreach(var name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}