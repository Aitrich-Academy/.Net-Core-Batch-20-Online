using Student_Management.models;

public class Program
{
    private static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            
            if (!context.Students.Any())
            {
                var students = new[]
                {
                    new Student { Name = "Aood Nazeer", Age = 30, Email = "anood@example.com" },
                    new Student { Name = "amina Afreen", Age = 22, Email = "amina@example.com" },
                    new Student { Name = "Muhammad Nasif", Age = 21, Email = "nasif@example.com" }
                };

                context.Students.AddRange(students);
                context.SaveChanges();
            }

            // Retrieve and display all student records
            var allStudents = context.Students.ToList();
            Console.WriteLine("Student Records:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
            }
        }
    }
}

    
