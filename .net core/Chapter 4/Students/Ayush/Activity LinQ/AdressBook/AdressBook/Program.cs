using System.ComponentModel.Design;
using AdressBook;

public class Program
{
    public static List<Country> person = new List<Country>();

    public static int count = 0;
    public static void Main(string[] args)
    {
        bool pgrm = false;
        while (!pgrm)
        {
            Console.WriteLine("\n------Welcome to Adress Book------\n");
            Console.WriteLine("1. Add person");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Group by country");
            Console.WriteLine("4. Group by city");
            Console.WriteLine("5. list person above 25 years old");
            Console.WriteLine("6. list person by cityname");
            Console.WriteLine("7. Address group by country");
            Console.WriteLine("8. Exit");

            Console.WriteLine("Enter choice: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    addperson();
                    break;


                case "2":
                    display();
                    break;

                case "3":
                    var query = person.GroupBy(e => e.countryname);

                    Console.WriteLine("*****-------*****");
                    foreach (var q1 in query)
                    {
                        Console.WriteLine($"\nCountry:{q1.Key}");
                        foreach (var q2 in q1.OrderBy(e => e.cityname).ThenBy(e => e.firstname).ThenByDescending(e => e.age))
                        {

                            Console.WriteLine($"Name: {q2.firstname + q2.lastname} City: {q2.cityname} Age:{q2.age}Address: {q2.homeaddress}");
                        }
                    }
                    break;

                case "4":
                    var query1 = person.GroupBy(e => e.cityname);
                    Console.WriteLine("*****-------*****");
                    foreach (var q1 in query1)
                    {
                        Console.WriteLine($"\nCity :{q1.Key}");
                        foreach (var q2 in q1)
                        {

                            Console.WriteLine($"Name: {q2.firstname + q2.lastname}  Address: {q2.homeaddress} Country:{q2.countryname}");
                        }
                    }
                    break;

                case "5":
                    listperson();
                    break;

                case "6":
                    listpersonbycity();
                    break;

                case "7":
                    Adressgroupbycountry();
                    break;

                case "8":
                    Console.WriteLine("Exiting....");
                    return;

                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
        }
    }

    public static void addperson()
    {
        Console.WriteLine("Enter First Name: ");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter Last Name: ");
        string lastname = Console.ReadLine();
        Console.WriteLine("Enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Home Address: ");
        string homeadress = Console.ReadLine();
        Console.WriteLine("Enter Work Address: ");
        string workaddress = Console.ReadLine();
        Console.WriteLine("Enter Roll Number: ");
        int rollnumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Building: ");
        string building = Console.ReadLine();
        Console.WriteLine("Enter street :");
        string street = Console.ReadLine();
        Console.WriteLine("Enter Phone number: ");
        string phone = Console.ReadLine();
        Console.WriteLine("Enter Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter city: ");
        string cityname = Console.ReadLine().ToLower();
        Console.WriteLine("Enter City ID: ");
        string cityid = Console.ReadLine();
        Console.WriteLine("Enter Country: ");
        string countryname = Console.ReadLine().ToLower();
        Console.WriteLine("Enter Country ID: ");
        string countryid = Console.ReadLine();
        person.Add(new Country(firstname, lastname, age, homeadress, workaddress, rollnumber, building, street, phone, email, cityid, cityname, countryid, countryname));
        count++;
        Console.WriteLine("Added Successfullly");
        return;
    }

    public static void display()
    {

        if (count == 0)
        {
            Console.WriteLine("No person to display!!!");
            return;
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nPerson{i + 1}");
                person[i].displayperson();
            }
        }
    }

    public static void listperson()
    {
        Console.WriteLine("*****-------*****");
        var query2 = person.FindAll(e => e.age > 25);
        foreach (var young in query2)
        {
            Console.WriteLine($"Name: {young.firstname + young.lastname} Age:{young.age} Country: {young.countryname}");
        }

    }

    public static void listpersonbycity()
    {
        Console.WriteLine("*****-------*****");
        Console.WriteLine("\nEnter city to find persons: ");
        string city = Console.ReadLine().ToLower();

        var query = person.FindAll(e => e.cityname == city && e.age < 20);
        if (query.Any())
        {
            foreach (var q1 in query)
            {
                Console.WriteLine($"Name:{q1.firstname + q1.lastname}  Age:{q1.age} Country: {q1.countryname}");
            }
        }
        else
        {
            Console.WriteLine("\n No such person found!!");
        }
    }

    public static void Adressgroupbycountry()
    {
        Dictionary<Country, List<Person>> dic = new Dictionary<Country, List<Person>>();

        var query = person.GroupBy(e => e.countryname);
        
        foreach(var q1 in query)
        {
            var list1 = q1.Key;
            var q7=q1.Where(e=>e.countryname == q1.Key).Select( e=>new { e.countryname , e.countryid });
            foreach(var c1 in q7)
            {
                Console.WriteLine($"Countryname: {c1.countryname} {c1.countryid}");
            }
            Country country1 = new Country();
            List<Person> person1=new List<Person>();
            foreach(var q2 in q1)
            {
                
                country1.countryid=q2.countryid;
                country1.countryname=q2.countryname;
                person1.Add(q2);
            }
            dic.Add(country1, person1);
        }

        


    }

}