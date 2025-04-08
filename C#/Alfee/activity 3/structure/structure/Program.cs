internal class Program
{
    public struct Student
    {
        public int Id;
        public string Name;
        public float Marks;

        public Student(int id, string name, float marks)
        {
          Id = id;
          Name = name;
          Marks = marks;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Marks: {Marks}");
        }

    }
    static void Main(string[] args)
    {
        Student student1 = new Student(367, "Alfiya Subair", 82.5f);

        student1.Display();

        Console.ReadLine();
    }
}