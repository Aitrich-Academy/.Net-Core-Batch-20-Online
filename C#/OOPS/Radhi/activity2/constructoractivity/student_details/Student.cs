using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_details
{
   public class Student
    {
        public string Name;
        public int Rollno;
        public string Grade;

       public Student(string name, int rollno,string grade)
        {
            Name = name;
            Rollno = rollno;
            Grade = grade;


        }
        public void Display_Details()
        {
            Console.WriteLine($"Name:{Name} \n Roll_No:{Rollno} \n Grade:{Grade}");
               
        }


    }
}
