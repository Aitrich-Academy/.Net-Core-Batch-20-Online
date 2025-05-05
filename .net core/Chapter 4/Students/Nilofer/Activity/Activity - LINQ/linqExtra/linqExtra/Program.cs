using linqExtra;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(1,"Amal",87),
            new Student(2,"Clinse",67),
            new Student(3, "Sanjay",45),
            new Student(4,"Sona",75),
            new Student(5,"Anila",44)

        };

        var q = students.Where(e => e.Score >= 60).OrderBy(e => e.Name).Select(e => new { e.Name,e.Score});

        Console.WriteLine("Students scored above 60\n");
        Console.WriteLine("Name    score");

        foreach (var student in q)
        {
            Console.WriteLine($"{ student.Name}    {student.Score}");
        }

        var q2 = students.GroupBy(s => s.Score >= 60 ? "Pass" : "Fail");

        foreach(var st in q2)

        {
            Console.WriteLine(st.Key);
            foreach(var student in st)
            {
                Console.WriteLine($"Id - {student.Id}  Name - {student.Name} Score - {student.Score}");
            }
        }


    }
}