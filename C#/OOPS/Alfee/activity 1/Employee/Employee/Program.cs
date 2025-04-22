using Employee_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Id = 12;
        emp.Name = "Alfiya Subair";
        emp.Salary = 250000;

        emp.Displaydetails();
    }
}