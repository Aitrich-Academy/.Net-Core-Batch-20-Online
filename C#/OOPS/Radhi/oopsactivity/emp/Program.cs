using emp;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Name = "Radhi";
        employee.Id = 1;
        employee.salary = 10000;
        employee.display();

    }
}