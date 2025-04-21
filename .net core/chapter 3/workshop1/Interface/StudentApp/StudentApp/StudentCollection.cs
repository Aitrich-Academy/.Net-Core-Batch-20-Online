using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
	public class StudentCollection :IStudentCollection
	{
		private Student[] students=new Student[10];
		public static Student st;
        public static int flag = 0;
        public StudentCollection()
		{
			students = new Student[10];
		}

		public void AddStudent(Student student)
		{
			for(int i = 0;i< students.Length; i++) {
				if (students[i] == null) {
					students[i] = student;
					break;
				}
				else
				{
					Console.WriteLine("The Array is fulll");
				}
			}
		}

		

		public Student GetStudent(string studentID)
		{
            foreach (Student student in students)
            {
				if(student!=null)
				{
                    if (student.StudentID == studentID)
                    {
                        flag=1;
                        st= student;
                        break;

                    }
                    else
                    {
                        flag=0;
                    }
                }
                
            }
			if(flag==1)
			{
				Console.WriteLine("The item is present");

			}
			return st;
        }

		public void ListAllStudents()
		{
			Console.WriteLine("List of Students:");
			foreach (var student in students)
			{
				if (student!=null)
				{
                    Console.WriteLine($"ID: {student.StudentID}, Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
                }
				
			}
		}
	}
}
