using markstudent;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        students.Add(new Student(1, "tony", 80));
        students.Add(new Student(2, "adhil", 100));
        students.Add(new Student(3, "ashish", 80));
        students.Add(new Student(4, "anu", 70));
        students.Add(new Student(5, "nayana", 60));

        var list = students.OrderBy(e => e.mark).ThenBy(e => e.id);

        foreach (var student in list)
        {
            Console.WriteLine($"Name: {student.name}  Id:{student.id}  Mark: {student.mark}");
        }




        //Console.WriteLine("Enter name: ");
        //string name=Console.ReadLine();
        //Console.WriteLine("Enter ID: ");
        //int id=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter mark: ");
        //int mark=Convert.ToInt32(Console.ReadLine());

        //students.Add(new Student(id,name,mark));

    }
}