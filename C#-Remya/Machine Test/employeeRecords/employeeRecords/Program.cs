using System.Xml.Linq;

internal class Program
{
    struct Employee
    {
        public int EmployeeID;
        public string Name;
        public double Salary;

    }
    private static void Main(string[] args)
    {
        // Question 1: Employee Records
        //A company wants to maintain records of its employees.Write a C# program that:
        //Declares a structure named Employee with fields EmployeeID(int), Name(string), and Salary(double).
        //Creates an array of 5 Employee structures.
        //Reads employee details from the user and stores them in the array.
        //Prints the details of all employees along with the highest and lowest salary.

        Employee[] e = new Employee[5];
        

        for (int i = 0; i < 5; i++) {
            Console.WriteLine("******Enter employee {0} details*******", i + 1);
            Console.WriteLine("Enter Employee ID");
            e[i].EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            e[i].Name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            e[i].Salary = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("+++++++ All employees details+++++++");
        Console.WriteLine();
        
        double highest = e[0].Salary;
        double lowest = e[0].Salary;
        int IDh =0, IDl=0;
        string hname = "", lname ="";
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("****** Employee {0} details*******", i + 1);
            Console.WriteLine(e[i].EmployeeID);
            Console.WriteLine(e[i].Name);
            Console.WriteLine(e[i].Salary);
            if (highest < e[i].Salary)
            {
                highest = e[i].Salary;
                IDh = e[i].EmployeeID;
                hname = e[i].Name;
            }
            else
            {
                if (lowest > e[i].Salary)
                {
                    lowest = e[i].Salary;
                    IDl = e[i].EmployeeID;
                    lname = e[i].Name;
                }
            }

        }
        Console.WriteLine($"Highest salaried employee name {hname} ID : {IDh} Salary: {highest}");
        Console.WriteLine($"Lowest salaried employee name {lname} ID : {IDl} Salary: {lowest}");

        

    }
}