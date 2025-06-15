using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Studentdetails
    {
        List<Student> students=new List<Student>();
        public void Addstudent()
        {
           
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Score: ");
            double score = double.Parse(Console.ReadLine());

            students.Add(new Student { ID = id, Name = name, Age = age, Score = score });
            Console.WriteLine("Student added successfully.");
        }
        public void Displaystudent()
        {
            if (students != null)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine($"ID:{student.ID}");
                    Console.WriteLine($"Name:{student.Name}");
                    Console.WriteLine($"Age:{student.Age}");
                    Console.WriteLine($"Score:{student.Score}");

                }
            }
            else
            {
                Console.WriteLine("No student records found.");

            }
        }
        public void CalculateAverage()
        {
            double total = 0;
            int count = 0;

            foreach (Student student in students)
            {
                total += student.Score;
                count++;
            }
            double average = total / count;
            Console.WriteLine($"Average:{average}");


        }
        public void Rank()
        {

        
        if (students.Count == 0)
    {
        Console.WriteLine("No student records to rank.");
        return;
    }

    List<Student> ranked = new List<Student>(students);

    // Manual sorting (descending by Score)
    for (int i = 0; i<ranked.Count - 1; i++)
    {
        for (int j = i + 1; j<ranked.Count; j++)
        {
            if (ranked[i].Score<ranked[j].Score)
            {
                var temp = ranked[i];
                ranked[i] = ranked[j];
                ranked[j] = temp;
            }
        }
    }

    Console.WriteLine("\n--- Ranked Students ---");
int rank = 1;
foreach (var student in ranked)
{
    Console.WriteLine($"Rank {rank++}: {student.Name} (Score: {student.Score})");
}
}
      public void RemoveStudent()
        {
            Console.Write("Enter the ID of the student to remove: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Student studentToRemove = null;
                foreach (var student in students)
                {
                    if (student.ID == id)
                    {
                        studentToRemove = student;
                        break;
                    }
                }

                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                    Console.WriteLine("Student removed successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }

     public  void FindStudent()
        {
            Console.Write("Enter ID or Name to search: ");
            string input = Console.ReadLine();

            List<Student> found = new List<Student>();

            if (int.TryParse(input, out int id))
            {
                foreach (var student in students)
                {
                    if (student.ID == id)
                    {
                        found.Add(student);
                    }
                }
            }
            else
            {
                foreach (var student in students)
                {
                    if (student.Name.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        found.Add(student);
                    }
                }
            }

            if (found.Count > 0)
            {
                Console.WriteLine("--- Student(s) Found ---");
                foreach (var s in found)
                {
                    Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Age: {s.Age}, Score: {s.Score}");
                }
            }
            else
            {
                Console.WriteLine("No student found matching the input.");
            }
        }






    }

}

