using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using AddressBook;

internal class Program
{
    public static List <Country> people = new List<Country> ();



    private static void Main(string[] args)
    {

        people.Add(new Country(
    "US01", "United States", "NY01", "New York", 101, "Apt 5B", "Broadway Street", "123-456-7890", "john.doe@example.com",
    "Ben", "Doe", new DateTime(1985, 4, 12),
    new Address(203, "Flat 7C", "Baker Street", "321-654-9870", "ben.smith@example.co.uk"),
    new Address(305, "Office Tower A", "Oxford Street", "321-654-9871", "ben.smith@workmail.co.uk")


));

        people.Add(new Country(
            "UK01", "United Kingdom", "LN01", "London", 203, "Flat 7C", "Baker Street", "321-654-9870", "jane.smith@example.co.uk",
            "Jane", "Smith", new DateTime(1990, 8, 24),
            new Address(203, "Flat 7C", "Baker Street", "321-654-9870", "jane.smith@example.co.uk"),
            new Address(305, "Office Tower A", "Oxford Street", "321-654-9871", "jane.smith@workmail.co.uk")
        ));

        people.Add(new Country(
            "JP01", "Japan", "TK01", "Tokyo", 505, "Block C", "Sakura Avenue", "852-963-7410", "hiroshi.tanaka@example.jp",
            "Hiroshi", "Tanaka", new DateTime(1995, 2, 18),
            new Address(505, "Block C", "Sakura Avenue", "852-963-7410", "hiroshi.tanaka@example.jp"),
            new Address(607, "Tech Park", "Akihabara Street", "852-963-7411", "hiroshi.tanaka@workmail.jp")
        ));

        people.Add(new Country(
            "IN01", "India", "DL01", "Delhi", 302, "House 12", "Connaught Place", "789-654-1230", "rahul.sharma@example.in",
            "Rahul", "Sharma", new DateTime(2007, 6, 5),
            new Address(302, "House 12", "Connaught Place", "789-654-1230", "rahul.sharma@example.in"),
            new Address(404, "Corporate Tower", "Nehru Place", "789-654-1231", "rahul.sharma@workmail.in")
        ));

        people.Add(new Country(
            "AU01", "Australia", "SY01", "Sydney", 410, "Villa 8A", "Harbour Street", "654-321-7890", "emily.davis@example.au",
            "Emily", "Davis", new DateTime(1992, 11, 9),
            new Address(410, "Villa 8A", "Harbour Street", "654-321-7890", "emily.davis@example"),
            new Address(512, "Business Center", "George Street", "654-321-7891", "emily.davis@workmail.au")
        ));


        string choice;
        do
        {
            Console.WriteLine("---------------Address Book----------------\n");

            Console.WriteLine("1- Add New Address ");
            Console.WriteLine("2- Display All addresses");
            Console.WriteLine("3- List Address By Country");
            Console.WriteLine("4- List Address by country,City,FirstName");
            Console.WriteLine("5 - List Address by Country,City,Age");
            Console.WriteLine("6 - List all persons Older than 25 years");
            Console.WriteLine("7 - List all persons working in a given city");
            Console.WriteLine("8 - List all persons working in a city under 20 years old");
            Console.WriteLine("9 - List of people by country");
            Console.WriteLine("10 - Exit");
            Console.WriteLine("Choose an option(1 - 9) : ");

            choice = Console.ReadLine();



            switch (choice)
            {
                case "1":
                    AddNewAddress();
                    break;
                case "2":
                    DisplayAll();
                    break;
                case "3":
                    ListByCountry();
                    break;
                case "4":
                    ListByCountryCityFirstName();
                    break;
                case "5":
                    ListByCountryCityAge();
                    break;
                case "6":
                    ListOlderthan25();
                    break;
                case "7":
                    WorkingInACity();
                    break;
                case "8":
                    WorkingUnder20();
                    break;
                case "9":
                    Adressgroupbycountry();
                    break;
                case "10":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        } while (choice != "10");
     }

    public static void AddNewAddress()
    {
        try
        {
            Console.WriteLine("Enter First Name : ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth (dd/mm/yyyy)");
            string date = Console.ReadLine();
            DateTime dob;
            if (!DateTime.TryParse(date, out dob))
            {
                Console.WriteLine("Invalid date format. Please enter the date in dd/mm/yyyy format.");
                return;
            }
            //DateTime.TryParse(date, out dob);
            Console.WriteLine("Enter home address:");
            Console.Write("Room no:");
            int homeRoomNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Building no :");
            string homebuilding = Console.ReadLine();
            Console.Write("Enter Street : ");
            string homestreet = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            string homePhone = Console.ReadLine();
            Console.Write("Enter Email : ");
            string email = Console.ReadLine();
            Console.Write("Enter City Id : ");
            string homecityid = Console.ReadLine();
            Console.Write("Enter City : ");
            string homecity = Console.ReadLine();
            Console.Write("Enter country id : ");
            string homecountryid = Console.ReadLine();
            Console.Write("Enter Country Name : ");
            string homecountry = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Work Address");
            Console.Write("Room no:");
            int WorkRoomNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Building no :");
            string Workbuilding = Console.ReadLine();
            Console.Write("Enter Street : ");
            string Workstreet = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            string WorkPhone = Console.ReadLine();
            Console.Write("Enter Email : ");
            string Workemail = Console.ReadLine();
            Console.Write("Enter City Id : ");
            string Workcityid = Console.ReadLine();
            Console.Write("Enter City : ");
            string Workcity = Console.ReadLine();
            Console.Write("Enter country id : ");
            string Workcountryid = Console.ReadLine();
            Console.Write("Enter Country Name : ");
            string Workcountry = Console.ReadLine();

            Country person = new Country(homecountryid, homecountry, homecityid, homecity, homeRoomNo, homebuilding, homestreet, homePhone, email, fname, lname, dob,
                new Address(homeRoomNo, homebuilding, homestreet, homePhone, email),
                new Address(WorkRoomNo, Workbuilding, Workstreet, WorkPhone, Workemail));

            people.Add(person);

            Console.WriteLine("Address Added Successfully....");
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

     }

    public static void DisplayAll()
    {
        try
        {
            foreach (Country person in people)
            {
                if (person != null)
                {
                    person.DisplayDetails();
                    
                }
            }
        }catch(Exception ex) { Console.WriteLine( ex.Message); }
    }

    public static void ListByCountry()
    {
        var q = people.GroupBy(x => x.CountryName);
        
        foreach(var q2 in q)
        {
            Console.WriteLine($"Country : {q2.Key}");
            Console.WriteLine($"Number of people : {q2.Count()}");
            Console.WriteLine("********************************************************************");

            foreach(var q3 in q2)
            {
               q3.DisplayDetails();
            }
        }
    }

    public static void ListByCountryCityFirstName()
    {
        var q = people.GroupBy(x => x.CountryName);

        foreach (var q2 in q)
        {
            Console.WriteLine($"Country : {q2.Key} \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        
            var q3 =q2.OrderBy(x => x.CityName).ThenBy(x => x.FirstName);
           

            foreach (var q4 in q3)
            {
               

                q4.DisplayDetails();
            }
        }

        
    }

    public static void ListByCountryCityAge()
    {
        var q = people.GroupBy(x =>x.CountryName);
        foreach (var q2 in q)
        {
            Console.WriteLine($"Country : {q2.Key} \n");
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            var q3 = q2.OrderBy(x => x.CityName).ThenByDescending(x => DateTime.Today.Year - x.DateOfBirth.Year);

            foreach (var q4 in q3)
            {

                q4.DisplayDetails();
            }
        }

    }

    public static void ListOlderthan25()
    {
        Console.WriteLine("....People Older than 25 years ....\n ");
        var q = people.Where(x => (DateTime.Today.Year - x.DateOfBirth.Year) > 25).Select(x => x);
        foreach (var q2 in q)
        {
            q2.DisplayDetails();
        }
           
       
    }

    public static void WorkingInACity()
    {
        Console.WriteLine("Enter City Name : ");
        string city= Console.ReadLine();

        var q = people.Where(x => x.CityName.ToLower().Equals(city.ToLower())).Select(x => x);
        foreach(var q2 in q)
        {
            q2.DisplayDetails();
        }
    }
    public static void WorkingUnder20()
    {
        Console.WriteLine("Enter City Name :");
        string city = Console.ReadLine();
        
        Console.WriteLine("....People Working below 20 years .... \n");
        var q = people.Where(x => (DateTime.Today.Year - x.DateOfBirth.Year) <20 && x.CityName == city).Select(x=> x);
        foreach (var q2 in q)
        {
            q2.DisplayDetails();
        }


    }

    public static void Adressgroupbycountry()
    {
        
        Dictionary<Country, List<Person>> dic = new Dictionary<Country, List<Person>>();

        
        var query = people.GroupBy(e => e.CountryName);

     
        foreach (var q1 in query)
        {
            
            Country country1 = new Country();
            List<Person> person1 = new List<Person>();

            
            foreach (var q2 in q1)
            {
                
                country1.CountryID = q2.CountryID;
                country1.CountryName = q2.CountryName;
                person1.Add(q2); 
            }

            
            dic.Add(country1, person1);
        }

       
        foreach (var e in dic)
        {
            Console.WriteLine($"Country: {e.Key.CountryName} (ID: {e.Key.CountryID})");

            foreach (var person in e.Value)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }




}




