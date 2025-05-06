using emp;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exit = false;
        Employeedetails em = new Employeedetails();
        string ch;
        while (!exit)
        {
            Console.WriteLine("1.AddEmployees \n2.DisplayEmployee \n3.SearchBy Department \n4exit");
            ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        em.Addingemp();
                        break;
                    }
                case "2":
                    {
                        em.display();
                        break;
                    }
                    case "3":
                    {
                        em.Searchbydepartment(); break;
                    }
                case "4":
                    {
                        exit = true;
                        Console.WriteLine("exiting...");
                        break;
                    }
                default:
                    Console.WriteLine("invalid entry");
                    break;
            }
        }




        }


    }
