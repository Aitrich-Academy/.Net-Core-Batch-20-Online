using StudentScoreSorting;
internal class Program
{


    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
        new Student(1934,"Azra",87),
        new Student(1254,"Sarah",78),
        new Student(1354,"Ayra",67),
        new Student(1490,"Ferah",89),
        new Student(1245,"Adnan",54),
        new Student(1564,"Shibly",78)

        };

        foreach (Student student in students)
        {
            student.Display();
        }

        Console.WriteLine();

        var linq = students.OrderBy(st => st.Score).ThenBy(st => st.Id).Select(st=>st);

        foreach (Student student in linq)
        {
            student.Display();
        }
        Console.WriteLine();

        var linqQuery = students.OrderByDescending(st => st.Score).ThenBy(st => st.Id).Select(st => st);

        foreach (Student student in linqQuery)
        {
            student.Display();
        }

        Console.WriteLine();

        var lin= from st in students
                 orderby st.Score descending, st.Id
                  select st;
        foreach (Student student in lin)
        {
            student.Display();
        }
    }
}