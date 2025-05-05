using Activity1;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>()
        { 90,100,40,50,20};

        var query=list.Where(e=>e>50).Select(e=>e);
        Console.WriteLine("-----Numbers----");

        foreach(var item in query)
        {
            Console.WriteLine(item);
        }

        List<Student> students = new List<Student>();
        students.Add(new Student(50,"ayush"));
        students.Add(new Student(90, "manu"));
        students.Add(new Student(40, "gokul"));
        Console.WriteLine();
        Console.WriteLine("---students above 80----");
        var queryy=students.Where(e=>e.score>80).Select(e=>e);
        foreach(var item in queryy)
        {
            Console.WriteLine(item.name);
        }

        Console.WriteLine();



        List<string> products = new List<string>()
        { "soap","brush","handwash","producttissue","productwhite"};

        var query1 = products.Where(e => e.Contains("pro")).Select(e=>e);

        Console.WriteLine("---products-----");

        foreach (var item in query1) 
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();




        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("ashish", 2020));
        employees.Add(new Employee("adhil", 2022));
        employees.Add(new Employee("manu", 2019));
        employees.Add(new Employee("sara", 2024));

        var query2 = employees.Where(e => e.year > 2020).Select(e => e);
        Console.WriteLine("-----Employee joined----");
        foreach (var emp in query2)
        {
            Console.WriteLine($"Name:{emp.Name} year: { emp.year}");
        }
        Console.WriteLine();



        List<object> objects = new List<object>()
        { "hello",1,"hii",8.5};
        Console.WriteLine("---Objects-----");

        //var present=from e in objects
        //            where e is string
        //            select e;

            //or

        var mixed = objects.OfType<string>();

        foreach (var i in mixed)
        {
            Console.WriteLine(i);
        }
      


    }
}