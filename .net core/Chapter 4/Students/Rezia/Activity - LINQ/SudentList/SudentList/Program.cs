using SudentList;

internal class Program
{
    private static void Main(string[] args)
    {
        List<StudentList> studentList = new List<StudentList>();
        int choice;

        do
        {

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Student");
            Console.WriteLine("3. Fetch student by ID");
            Console.WriteLine("4. Exit");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid option");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter id ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();

                    studentList.Add(new StudentList { Id = id, Name = name });

                    Console.WriteLine("Sudent added successfullt");
                    break;

                case 2:

                    Console.WriteLine("Student List:- ");

                    foreach (var student in studentList)
                    {
                        Console.WriteLine(student);
                    }
                    break;

                case 3:

                    //if (studentList.Count == 0)
                    //{
                    //    Console.WriteLine("No student found");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Enter id to fetch student details");
                    //    int fetchid = Convert.ToInt32(Console.ReadLine());

                    //    StudentList fetchstudent = null;
                    //    foreach (var student in studentList)
                    //    {
                    //        if (student.Id == fetchid)
                    //        {
                    //            fetchstudent = student;
                    //            break;
                    //        }

                    //    }
                    //    if (fetchstudent == null)
                    //    {
                    //        Console.WriteLine("No student found");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Student Details");
                    //        Console.WriteLine(fetchstudent);
                    //    }
                    //}
                    //break;
                    var linqquery = from x in studentList
                                    where x.Id == 2
                                    select x;

                    foreach (var student in linqquery)
                    {
                        Console.WriteLine(student);
                    }
                    break;
            
        
                    
                case 4:

                    Console.WriteLine("Exiting ...");
                    return;

                default:

                    Console.WriteLine("Invalid option");
                    break;
            }
        } while (choice != 3);
    }
    }
