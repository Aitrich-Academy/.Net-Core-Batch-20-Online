using Exercise.Exceptions;
using Exercise.Interface;
using Exercise.Manager;
using Exercise.Model;
using Exercise.Repository;
using System.Text.RegularExpressions;

IRepository userInterface = new UserRepository();
string ch, choice;
do
{
    Console.WriteLine("Select Options");
    Console.WriteLine("1.Login");
    Console.WriteLine("2.Register");
    Console.WriteLine("3.Exit");
    Console.WriteLine("Enter user choice");
    ch = Console.ReadLine();

    switch (ch)
    {
        case "1":
            Login();
            break;
        case "2":
            Register();
            break;
            case "3":
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("invalid");
            break;



    }


    Console.WriteLine("Do you wqant contiunye :(y/n)");
    choice = Console.ReadLine();

} while (choice == "y");
void Login()
{
    try
    {


        Console.WriteLine("Enter your email id :");
        string Email = Console.ReadLine();
        Console.WriteLine("Enter password");
        string Password = Console.ReadLine();


        User loggedUser;
        loggedUser = userInterface.Login(Email, Password);

        if (loggedUser != null)
        {
            Console.WriteLine("Logged Successfull");
            Console.WriteLine("Welcome {0}", loggedUser.FirstName);

            AdminManager admin = new AdminManager();
            admin.DisplayMenu();

            


        }
        else
        {
            Console.WriteLine("Not Successfull");
        }





    }
    catch (Exception ex) { Console.WriteLine(ex.Message); }
}

void Register()
{
    try
    {
        User newJobSeeker = new User();

        Console.WriteLine("Please enter your first name:");
        newJobSeeker.FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name:");
        newJobSeeker.LastName = Console.ReadLine();

       
        newJobSeeker.Email = GetEmail();

        newJobSeeker.Phone = GetPhoneNumber();


        Console.WriteLine("Please enter a password:");
        newJobSeeker.Password = Console.ReadLine();

        userInterface.Register(newJobSeeker);

        Console.WriteLine("Registration successful");
        

    }
    catch (UserException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

string GetEmail()
{
    try
    {
        Console.WriteLine("Please enter your email address:");
        string email = Console.ReadLine();
        Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

        if (!regex.IsMatch(email))
            throw new InvalidException("email was not in correct format :" + email);
        return email;
    }
    catch (InvalidException ex)
    {
        Console.WriteLine(ex.Message + "\n");
        Console.WriteLine("try again...");
        return GetEmail();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message + "\n");
        return GetEmail();
    }
}
long GetPhoneNumber()
{
    try
    {
        Console.WriteLine("Please enter your phone number:");
        long Phone = long.Parse(Console.ReadLine());
        return Phone;
    }
    catch (Exception e)
    {
        Console.WriteLine("Enter valid phone number");
        return GetPhoneNumber();
    }
}
