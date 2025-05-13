using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPAApp
{
    public class Student
    {
        public string Name { get; set; }

        private int age;

        public double Marks1 { get; set; }
        public double Marks2 { get; set; }
        public double Marks3 { get; set; }
        public double Marks4 { get; set; }
        public double Marks5 { get; set; }
        public double Marks6 { get; set; }
  
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 25)
                    throw new ArgumentOutOfRangeException("Age must be between 18 and 25.");

                age = value;
            }
        }


        public double CGPA { get; private set; }
        public string Grade { get; private set; }


        public void CalculateCGPA()
        {
            double totalMarks = Marks1 + Marks2 + Marks3 + Marks4 + Marks5 + Marks6;
            CGPA = (totalMarks / 600) * 10;  

            if (CGPA >= 9)
                Grade = "A";
            else if (CGPA >= 8)
                Grade = "B";
            else if (CGPA >= 7)
                Grade = "C";
            else if (CGPA >= 6)
                Grade = "D";
            else if (CGPA >= 5)
                Grade = "E";
            else
                Grade = "Failed";
        }
    }

    
    }

