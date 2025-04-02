using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

internal class Program

{
    public struct Student
    {
        public int Id;
        public string Name;
        public float Mark;

       public Student(int id, string name, float mark)
        {
            Id = id;
            Name = name;
            Mark = mark;

        }
        public void  Display()
        {
            Console.WriteLine($"Id :{Id} \n Name:{Name} \n Mark:{Mark} ");
        }

        

    }
    private static void Main(string[] args)
    {
    Student student1 = new Student(56,"radhi",45);
        student1.Display();
    }
}