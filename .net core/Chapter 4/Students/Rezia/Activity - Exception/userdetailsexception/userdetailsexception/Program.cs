using System.Text.RegularExpressions;
using userdetailsexception;
using userdetailsexception.Exception;


internal class Program
{
    private static User[] userarray = new User[2];
    private static int usercount = 0;
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the User System");

        while (true)
        {
            Console.WriteLine(" Menu");
            Console.WriteLine("1. AddUser");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Choose an option");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddUser();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Exiting the application....GoodBye");
                break;
            } else
            {
                Console.WriteLine("Invalid option, please try again");
            }
        }
    }
            private  static void AddUser() { 

        Console.WriteLine("\n Add new user");

        int id = GetValidID();
        string name = GetValidName();
        string phone = GetValidPhone();
        string email = GetValidEmail();
          
        User user = new User(id, name, phone, email);

            userarray[usercount] = user;
            usercount++;

            Console.WriteLine("User Added Successfully");
            Console.WriteLine(user);

        }
    
    private static int GetValidID()
    {
        while (true)
        {
            Console.WriteLine("Enter User ID");
            string inputid = Console.ReadLine();
            try
            {
                if (string.IsNullOrEmpty(inputid))
                {
                    throw new ValidateIDException("ID cannot be empty or null");
                }
                if (!int.TryParse(inputid, out int id))
                {
                    throw new ValidateIDException("ID shoud be an integer");
                }
                return id;
            }
            catch (ValidateIDException e)

            {
                Console.WriteLine("Exception error " + e.Message);
            }


        }
    }
    public static string GetValidName() {

        while (true)
        {
            Console.WriteLine("Enter the name of user");
            string name = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ValidationUserDetails("Name cannot be null or empty");
                }
                if (Regex.IsMatch(name, @"\d"))
                {
                    throw new ValidationUserDetails("Name should be in proper format");
                }
                return name;
            }
            catch (ValidationUserDetails e)
            {
                Console.WriteLine("Validation Error " + e.Message);
            }
        }
    }
    public static string GetValidPhone() {
        while (true)
        {
            Console.WriteLine("Enter the Phone Number");
            string phone = Console.ReadLine();

            try
            {
                if (phone.Length != 10 || Regex.IsMatch(phone, @"^\d {10}$"))
                {
                    throw new ValidatephoneException("Phone number must be 10 digits");
                }
                return phone;
            }
            catch (ValidatephoneException e)
            {
                Console.WriteLine("Validation Error " + e.Message);
            }
        }
    }
    public static string GetValidEmail()
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        while (true)
        {
            Console.WriteLine("Enter the Email ID");
            string email = Console.ReadLine();

            try
            {
                if (!Regex.IsMatch(email, pattern))
                
                    throw new ValidateEmailException($"The email id {email} is not correct format");

                
                return email;

            }
            catch (ValidateEmailException e)
            {
                Console.WriteLine("Validation Error" + e.Message);

            }
        }
    }
        }
    

    























