using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoringSystem
{
    internal class Student
    {
        public int ID;
        public string Name;
        public int Age;
        public int Score;

        public Student() { }
        public Student(int id, string name, int age, int score)
        {
            this.ID = id;
            this.Name = name; ;
            this.Age = age;
            this.Score = score;

        }
        public void Display()
        {
            Console.Write("**********************\n");
            Console.WriteLine("ID : {0}", ID);
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Age :{0}", Age);
            Console.WriteLine("Score :{0}", Score);
            Console.WriteLine("--------------------------");


        }

    }
}
