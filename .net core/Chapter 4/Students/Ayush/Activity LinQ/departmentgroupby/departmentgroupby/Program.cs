using departmentgroupby;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student(1,"manu","IT"));
        students.Add(new Student(2, "alok", "CSE"));
        students.Add(new Student(3, "asok", "CSE"));
        students.Add(new Student(4, "aman", "IT"));
        students.Add(new Student(5, "loki", "COMMERCE"));
        students.Add(new Student(6, "loki", "humanity"));

        var query = students.GroupBy(e => e.department);

        //foreach (var item in query)
        //{
        //    Console.WriteLine($"Department: { item.Key}");

        //    foreach(var student in item)
        //    {
        //        Console.WriteLine($"ID: {student.Id} Name: {student.Name}");
        //    }
        //}

        foreach(var q1 in query)
        {
            
            Console.WriteLine($"Department {q1.Key} : {q1.Count()} :Students");


            
        }
        Console.WriteLine($"Total number of departments: {query.Count()}");


    }
}
