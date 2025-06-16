using Activity2.Model;

internal class Program
{
    private static void Main(string[] args)
    {
       var Db=new StudentContext();
        Db.Students.Add(new Student { StudentName = "Radhi", Age = 23, Email = "RAdhi@gmail.com" });
     Db.Students.Add(new Student { StudentName = "kian", Age = 25, Email = "Kian@gmail.com" });
        Db.Students.Add(new Student { StudentName = "Renya", Age = 23, Email = "Renyai@gmail.com" });
       Db.SaveChanges() ;
        foreach(var student in Db.Students)
        {
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Email);
        }
    }
}
    
