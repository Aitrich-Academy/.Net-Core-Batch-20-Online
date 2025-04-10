internal class Program
{
    struct Provider
    {
        public string email;
        public string password;
        public string designation;
        public string phoneno;
        public string name;


    }
    public static void Main(string[] args)
    {
        Provider pro = new Provider();
        Provider[] p =new  Provider[5];
        int count=0;
        string? response = "";
        int choice,ch;
        Console.WriteLine("*******Welcome********");

        do
        {
            Console.WriteLine("1.Login");
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your email");
                        pro.email = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter your password");
                        pro.password = Console.ReadLine();
                        Console.WriteLine("**************************");
                        if (pro.email == "provider@gmail.com" && pro.password == "1234")
                        {
                            Console.WriteLine("Login Successfully");

                        }
                        else
                        {
                            Console.WriteLine("invalid username or password");
                        }

                        break;
                    }
                default:
                    Console.WriteLine("Enter valid choice");
                    continue;

            }

            Console.WriteLine("**************************************");
            Console.WriteLine("1.List all company members \n");
            Console.WriteLine("2.Add company members \n");
            Console.WriteLine("3.Logout \n");
            Console.WriteLine("**************************************");
            ch=Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("userId       \t|name       \t|Email             \t|Phone");
                        Console.WriteLine("________________________________________________________________");


                        for (int i = 0; i < count; i++)
                        {


                            Console.WriteLine($"{i}           \t{p[i].name}     \t{p[i].email}         \t{p[i].phoneno}");
                            Console.WriteLine();
                           
                        }

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("How many members do you want to add?");
                        count=Convert.ToInt32(Console.ReadLine());
                        
                        for (int i = 0; i < count; i++)
                        {


                            Console.WriteLine("please enter company member name:");
                            p[i].name = Console.ReadLine();
                            Console.WriteLine("please enter email:");
                            p[i].email = Console.ReadLine();
                            Console.WriteLine("please enter designation");
                            p[i].designation = Console.ReadLine();
                            Console.WriteLine("please enter your phone number");
                            p[i].phoneno = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------------------------");
                        }
                        Console.WriteLine("------Registration Successful----");
                        break;
                    }
                default:
                    Console.WriteLine("Logout");
                    continue;
            }

                   


                    

            





            Console.WriteLine("Do you want to continue Y/N");
            response = Console.ReadLine();
        }while("Y"==response||"y"==response);
            


        }
    }
