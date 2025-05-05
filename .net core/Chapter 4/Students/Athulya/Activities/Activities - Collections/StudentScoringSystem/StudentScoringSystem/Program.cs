using System.Security.Cryptography.X509Certificates;

namespace StudentScoringSystem
{
    internal class Program
    {
        public static List<Student> students = new List<Student>();
        public static void Main(string[] args)
        {
            string choose = "";
            try
            {
                while (choose != "6")
                {
                    Console.WriteLine("Students Score board");
                    Console.WriteLine("Choose options");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Display");
                    Console.WriteLine("3.Remove");
                    Console.WriteLine("4.Find");
                    Console.WriteLine("5.Display Rank");
                    Console.WriteLine("6.Exit");
                    choose = Console.ReadLine();
                    switch (choose)
                    {
                        case "1":
                            Add();
                            break;

                        case "2":
                            foreach (Student stu in students)
                            {
                                if (stu != null)
                                {
                                    stu.Display();
                                }
                            }
                            CalculateAverage();

                            break;

                        case "3":


                            Remove();

                            break;
                        case "4":
                            Console.WriteLine("Enter student id ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Student student = FindStudent(id);
                            if (student != null)
                            {
                                student.Display();

                            }
                            break;
                        case "5":
                            Rank();
                            break;
                        case "6":
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("invalid");
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void Add()
        {
            try
            {
                Console.WriteLine("Enter id :");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name :");
                string Name = Console.ReadLine();
                Console.WriteLine("enter age :");
                int Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("eNTER sCORE :");
                int Score = Convert.ToInt32(Console.ReadLine());

                students.Add(new Student(Id, Name, Age, Score));
                Console.WriteLine("Students details Added Successfully");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }
        public static void CalculateAverage()
        {
            int total = 0;
            float average;
            try
            {
                foreach(Student student in students)
                {
                    total = total + student.Score;
                }
                average=total / students.Count;
                Console.WriteLine("Average Score :", average);
            }catch(Exception e) { Console.WriteLine(e.Message); }
        }
        public static void Remove()
        {
            try
            {
                Console.WriteLine("enter student id for remove:");
                int id = Convert.ToInt32(Console.ReadLine());
                Student student = FindStudent(id);
                if (student != null)
                {
                    students.Remove(student);
                    Console.WriteLine("student removed successfully");
                }

            }catch(Exception e) { Console.WriteLine(e.Message);  }
            }
        public static Student FindStudent(int id)
        {
            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    return student;
                }

            }
                    Console.WriteLine("Student not found");
                    return null;
        }
        public static void Rank()
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
                Console.WriteLine("{0}  Rank : {1}   Score : {2}", students[i].Name, i + 1, students[i].Score);
            }

        }
    }
}




              