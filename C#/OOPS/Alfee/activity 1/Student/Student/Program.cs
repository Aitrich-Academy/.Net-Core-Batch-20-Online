using Student_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Anzal Subair";
        student1.Age = 18;
        student1.Grade = "12th Grade";

       
        student1.DisplayDetails();
    }
}