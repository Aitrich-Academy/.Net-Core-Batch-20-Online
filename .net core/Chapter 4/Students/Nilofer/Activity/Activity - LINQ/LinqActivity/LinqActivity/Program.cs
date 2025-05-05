using LinqActivity;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Atira"),
            new Student(2, "Achu"),
            new Student(3, "Deepika"),
            new Student(4, "Deepthi")
        };

        foreach (Student st  in students)
        {
            Console.WriteLine($"Id: {st.Id}, Name: {st.Name}");
        }

        Console.WriteLine("Enter student id");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Student student in students)
        {
           if( student.Id == id)
            {
                Console.WriteLine($"Student with id {id} is {student.Name}");
            }
        }

        var linqquery = from e in students
                        where e.Id == id
                        select e;
        foreach(var st in linqquery)
        {
            Console.WriteLine(st.Name);
        }

        List<int> list = new List<int>()
        { 1,5,6,89,40,8,7};

        var linq = from e in list
                   where e > 5 && e < 10
                   select e;
        Console.WriteLine("Numbers between 5 & 10 are : ");
        foreach (var i in linq)
        {
           
            Console.WriteLine(i);
        }

        var lin = list.Where(a => a > 5 && a < 10).Select(a => a);

        foreach (var i in lin)
        {

            Console.WriteLine(i);
        }

        List<string> words = new List<string>()
        {
            "above","end","depth","up","down","between"
        };

        var w = from e in words
                where e.Contains("e")
                select e;
        foreach(var word in w)
        {
            Console.WriteLine(word);
        }
    }
}