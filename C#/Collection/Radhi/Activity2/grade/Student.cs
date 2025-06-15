using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }
    class StudentManager
    {
        private SortedList<int, Student> students = new SortedList<int, Student>();

        // Add a student
        public void AddStudent(int id, Student student)
        {
            if (!students.ContainsKey(id))
            {
                students.Add(id, student);
                Console.WriteLine("Student added successfully.");
            }
            else
            {
                Console.WriteLine("A student with this ID already exists.");
            }
        }

        // Display students with Grade > 80
        public void DisplayHighGradeStudents()
        {
            Console.WriteLine("Students with Grade > 80:");
            foreach (var pair in students)
            {
                if (pair.Value.Grade > 80)
                {
                    Console.WriteLine($"ID: {pair.Key}, {pair.Value}");
                }
            }
        }
    }

   


}








