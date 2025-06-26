using Accademy.Modal;

public class Program
{
    private static void Main(string[] args)
    {
        var db = new AppDbContext();
       var db1 = new AppDbContext();

        // Insert data
        db.students.Add(new Student { Student_Name  = "Anu"});
        db.SaveChanges();

        foreach (var item in db.students)
        {
            Console.WriteLine(item.Student_Name);    
        }

        db1.marks.Add(new Mark { Subject = "Maths", Subject_Mark = 45 });
        db1.SaveChanges();

        foreach (var item in db1.marks)
        {
            
            Console.WriteLine(item.Subject);
            Console.WriteLine(item.Subject_Mark);
        }
    }
}