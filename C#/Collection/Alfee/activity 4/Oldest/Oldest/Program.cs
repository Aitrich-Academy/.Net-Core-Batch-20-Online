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
            new Person { Name = "Eren", Age = 30 },
            new Person { Name = "Mikasa", Age = 25 },
            new Person { Name = "Annie", Age = 40 },
            new Person { Name = "Connie", Age = 35 }
        };
        int maxAge = (from person in people select person.Age).Max();

        var oldest = from person in people
                     where person.Age == maxAge
                     select person;

        foreach(var p in oldest)
        {
            Console.WriteLine($"Oldest Person: {p.Name}, Age: {p.Age}");
        }
    }
}