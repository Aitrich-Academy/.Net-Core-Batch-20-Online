internal class Program
{
  
       struct Interview
    {
        public string jobtitle;
        public DateTime date;
        public string time;
        public string location;




    }
   public static void Main(string[] args)
    {

        Interview[] schedule = new Interview[5];

        int count=0;
        string? response = null;
        Console.WriteLine("******INTTERVIEW SCHEDULING******");
        Console.WriteLine();


        do
        {
            Console.WriteLine("A.Shedule a interview \nB.sheduled interview List \n");
            Console.WriteLine();
            Console.WriteLine("Enter your choice(A/B)");
            Console.WriteLine();
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "A":
                    {
                        Console.WriteLine("How many no of interviews are sheduling\n");
                        count =Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Enter the Jobtitle: ");
                            schedule[i].jobtitle = Console.ReadLine();


                            Console.Write("Enter a date (dd/MM/yyyy): ");
                            schedule[i].date = Convert.ToDateTime(Console.ReadLine());

                            Console.WriteLine("Enter a time for interview");
                            schedule[i].time = Console.ReadLine();

                            Console.WriteLine("Enter a Location for interview");
                            schedule[i].location = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("*********************************************");

                        }
                       
                        break;
                    }

                case "B":
                    {
                        Console.WriteLine("****Sheduled interview Details are are:****");

                        for (int i = 0; i <count; i++)
                        {
                           


                                Console.WriteLine($"JobTitle :{schedule[i].jobtitle}");
                                Console.WriteLine($"date :{schedule[i].date.Date.ToString("MM/dd/yyyy")}");
                                Console.WriteLine($"Time :{schedule[i].time}");
                                Console.WriteLine($"Location :{schedule[i].location}");
                                Console.WriteLine("\n");
                                Console.WriteLine("*********************************************");
                            
                        }
                        break;
                    }

                        default:
                    
                        Console.WriteLine("Invalid Entry,Try again....");
                        continue;
                    





            }

            Console.WriteLine("if you want to continue(y/n)");
            Console.WriteLine();
            response = Console.ReadLine();


        } while (response == "Y" || response == "y");

    }
}