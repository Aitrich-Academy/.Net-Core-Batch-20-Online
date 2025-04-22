using School_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Alfiya", 25);
        student.ShowDetails();
        student.GetRole();

        Console.WriteLine();

        Teacher teacher = new Teacher("Anzal", 30);
        teacher.ShowDetails();
        teacher.GetRole();
    }
}