using Studentscore;
using Studentscore.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        int choice;
        do
        {
            Console.WriteLine("Welocome to Student data application");
            Console.WriteLine("1. Add Stuent");
            Console.WriteLine("2. Display all students");
            Console.WriteLine("3. Calculate Average Score");
            Console.WriteLine("4. Student's Rank");
            Console.WriteLine("5. Remove a student");
            Console.WriteLine("6. Find Student");
            Console.WriteLine("7. Exit");
           
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Choice should be an integer");
                    break;
                }
            try
            {

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;
                    case 2:
                        DisplayStudent(students);
                        break;
                    case 3:
                        AverageScore(students);
                        break;
                    case 4:
                        RankStudent(students);
                        break;
                    case 5:
                        RemoveStudent(students);
                        break;
                    case 6:
                        FindStudent(students);
                        break;
                    case 7:
                        Console.WriteLine("Exiting the application.....Goodbye");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid choice" + ex.Message);
            }
            
        } while (choice != 7);
    }
    public static void AddStudent(List<Student> students)
    {
        try
        {
            Console.WriteLine("Enter the ID of student :");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of student : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age of student :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Score of student :");
            double score = Convert.ToInt32(Console.ReadLine());

            students.Add(new Student { Id = id, Age = age, Name = name, Score = score });

            Console.WriteLine("Student Added Successfully");
            Console.WriteLine("***************************************");
        }catch (Exception ex)
        { 
            Console.WriteLine("Invalid input. Please enter numeric values for id, age score" + ex.Message); 
        }

    }
    public static void DisplayStudent(List<Student> students) 
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Student list is empty");
            return ;
        }

        Console.WriteLine("Student details are given below ");
        Console.WriteLine("___________________________________");

        foreach(var student in students)
        {
         
            Console.WriteLine(student);

        }
            
    }
    public static void AverageScore(List<Student> students) 
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Student list is empty");
            return ;    
        }
        double totalscore = 0;
        foreach(var student in students)
        {
            totalscore += student.Score;
        }
        double average = totalscore / students.Count;
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine($"The average score of given students are : {average}");
        Console.WriteLine();
    }
    public static void RankStudent(List<Student> students)
    {
        try
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Student list is empty");
                return;
            }
            Console.WriteLine("Enter the student id to find rank : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student rankStudent = null;
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    rankStudent = student;
                    break;
                }
            }
            if (rankStudent == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            int rank = 1;
            foreach (var student in students)
            {
                if (student.Score > rankStudent.Score)
                {
                    rank++;
                }

            }
            Console.WriteLine($"Rank of student ID :{rankStudent.Id}, Name :{rankStudent.Name}  :-  {rank}");

                }

        catch (NumericException ee) {
            Console.WriteLine("Ivalid input, Please enter numeric values" + ee.Message);
        }
    }
    public static void RemoveStudent(List<Student> students)
    {
        try
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Student list is empty");
            }
            Console.WriteLine("Enter the id of student to remove");
            int id = Convert.ToInt32(Console.ReadLine());

            Student removestudent = null;
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    removestudent = student;
                    break;
                }
            }
            if (removestudent == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                students.Remove(removestudent);
                Console.WriteLine("Student Remove successfully");
            }
        }
        catch (NumericException ee)
        {
            Console.WriteLine("Invalid value" + ee.Message);
        }
        
    }
    public static void FindStudent(List<Student> students) 
    {
        try
        {
            Console.WriteLine("Enter the id of student to find");
            int id = Convert.ToInt32(Console.ReadLine());

            Student findstudent = null;
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    findstudent = student;
                    break;
                }
            }
            if (findstudent == null)
            {
                Console.WriteLine("Student not found");

            }
            else
            {

                Console.WriteLine("Student found");
                Console.WriteLine(findstudent);
            }
        }
        catch (NumericException ee)
        {
            Console.WriteLine("Invalid values" + ee.Message);
        }
    }
}

