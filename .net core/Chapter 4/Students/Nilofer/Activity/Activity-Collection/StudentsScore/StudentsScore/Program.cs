using System.Security.Cryptography.X509Certificates;
using StudentsScore;

internal class Program
{
    public static List<Student> students = new List<Student>();
    public static void Main(string[] args)
    {
        string choice = "";

        try
        {

            while (choice != "6")
            {

                Console.WriteLine("-----------Students Score--------------\n");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - Add Student");
                Console.WriteLine("2 - Display students");
                Console.WriteLine("3 - Remove a student");
                Console.WriteLine("4 - Find a Student");
                Console.WriteLine("5 - Display students with Rank");
                Console.WriteLine("6 - Exit ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();

                        break;

                    case "2":
                        foreach (Student stu in students)
                        {
                            if (stu != null)
                            {
                                stu.DisplayStudents();
                            }
                        }

                        CalculateAverage();



                        break;

                    case "3":

                        RemoveStudent();
                        break;

                    case "4":
                        Console.WriteLine("Enter student Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Student student = FindStudent(id);
                        if (student != null)
                        {
                            student.DisplayStudents();
                        }
                        break;

                    case "5":

                        RankStudents();
                        break;

                    case "6":
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;


                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void AddStudent()
    {
        try
        {
            Console.WriteLine("Enter Id : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age of the student: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Score : ");
            int score = Convert.ToInt32(Console.ReadLine());

            students.Add(new Student(Id, name, age, score));
            Console.WriteLine("Student Added Successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public static void CalculateAverage()
    {
        int Total = 0;
        float average;
        try
        {
            foreach (Student student in students)
            {
                Total = Total + student.Score;


            }
            average = Total / students.Count;
            Console.WriteLine($"Average Score : {average}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void RemoveStudent()
    {
        try
        {
            Console.WriteLine("Enter Student Id to remove : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = FindStudent(id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully");
            }
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
          
    }

    public static Student FindStudent(int id)
    {
        foreach(Student student in students)
        {
            if (student.Id == id) {  return student; }
            
        }
        Console.WriteLine("Student not found");
        return null;
    }

    public static void RankStudents()
    {
        for (int i = 0; i < students.Count; i++)
        {
            for (int j = i + 1; j < students.Count; j++)
            {
                if (students[i].Score < students[j].Score)
                {

                    var temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }

        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{students[i].Name}  Rank : {i + 1}   Score : {students[i].Score}");
        }

    }
}