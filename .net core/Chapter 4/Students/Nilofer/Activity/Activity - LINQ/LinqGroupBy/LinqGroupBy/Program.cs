using LinqGroupBy;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(1,"Kenz","IT"),
            new Student(2,"Ferah","IT"),
            new Student(3,"Azra","CSE"),
            new Student(4,"Amna","IT"),
            new Student(5,"Dilul","CSE"),
            new Student(6,"luham","IT"),
            new Student(7,"Serah","ECE"),

        };

        var q = students.GroupBy(x => x.Department);

        Console.WriteLine($"Number of Departments : {q.Count()}");
        Console.WriteLine();
        foreach (var q2 in q)
        {
            Console.WriteLine(q2.Key);
            Console.WriteLine(q2.Count());
            
            foreach (var q3 in q2)
            {
               
                Console.WriteLine($"Name : {q3.Name}  Id : {q3.Id}");
            }
           
            Console.WriteLine();
        }

        var q4 = from x in students
                 group x by x.Department;


        foreach (var q2 in q4)
        {
            Console.WriteLine(q2.Key);
            Console.WriteLine(q2.Count());

            foreach (var q3 in q2)
            {
                Console.WriteLine($"Name : {q3.Name}  Id : {q3.Id}");
            }
           
            Console.WriteLine();
        }



    }
}