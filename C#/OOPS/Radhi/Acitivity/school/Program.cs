using school;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("radhi",23);
        Teacher teacher = new Teacher("meea",35);


        Console.WriteLine("Student Details:");
        student.ShowDetails();
        student.GetRole();

        Console.WriteLine("\nTeacher Details:");

        teacher.ShowDetails();
        teacher.GetRole();

    }
}