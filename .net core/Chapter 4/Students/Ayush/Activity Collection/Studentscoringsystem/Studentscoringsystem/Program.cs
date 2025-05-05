using Studentscoringsystem;

public class Program
{
    public static List<Student> students = new List<Student>();
    public static int count = 0;

    public static void Main(string[] args)
    {
    bool pgrm=false;
        while (!pgrm)
        {
            Console.WriteLine("----Welcome To Student Scoring System----");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Student");
            Console.WriteLine("3. Average score");
            Console.WriteLine("4. Find student");
            Console.WriteLine("5. Remove student");
            Console.WriteLine("6. Rankstudent");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter you choice: ");
            string choice=Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Add();
                    break;
                
                case "2":
                    display();
                    break;

                case"3":
                    averagescore(); 
                    break;

                case"4":
                    findstudent();
                    break;

                case "5":
                    removestudent();
                    break;

                case "6":
                    Rank();
                    break;

                case "7":
                    Console.WriteLine("Exiting....");
                    return;

                default:
                    Console.WriteLine("Invalid choice!!!!");
                    break;

            }
        }
    }

    public static void Add()
    {
        try
        {


            Console.WriteLine("Enter ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            students.Add(new Student(id, name, age, score));
            count++;
            Console.WriteLine("Student added succesfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void display()
    {
        if (count == 0)
        {
            Console.WriteLine("No students to display");
            return;
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("----Details----");
                Console.WriteLine($"Student{i + 1}");
                students[i].displaystudents();
            }
            

        }
    }

    public static void averagescore()
    {
        if (count == 0)
        {
            Console.WriteLine("no students");
            return;
        }
        double totalscore = 0;
        foreach (var student in students)
        {
            totalscore += student.score;
        }
        double averagescore = totalscore / count;
        Console.WriteLine($"Average score: {averagescore}");
    }


    public static void findstudent()
    {
        Console.WriteLine("Enter id to find student: ");
        string findid = Console.ReadLine();
        bool found = false;

        foreach (var student in students)
        {
            if (student.id == findid)
            {
                found = true;
                Console.WriteLine("student found");
                student.displaystudents();
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"student with {findid} not found!!!");
        }
    }


    public static void removestudent()
    {
        Console.WriteLine("Enter id to remove student");
        string removeid = Console.ReadLine();
        bool found = false;

        for(int i = 0; i<count;i++)
        {
            if (students[i].id == removeid)
            {
                students.RemoveAt(i);
                found = true;
                Console.WriteLine("Student removed successfully");
                break;
            }
           
        }
        if (!found)
        {
            Console.WriteLine($"student with {removeid} does not exist.");
        }

    }

    public static void Rank()
    {
        if(count == 0)
        {
            Console.WriteLine("No students ");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            for (int j = i+1; j < count; j++)
            {
                if (students[i].score < students[j].score)
                {
                    var temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("---Student Ranking----");
        foreach (var student in students)
        {
            Console.WriteLine($"ID :{student.id}  Name: {student.name} Score:  {student.score}");
        }



    }



}
