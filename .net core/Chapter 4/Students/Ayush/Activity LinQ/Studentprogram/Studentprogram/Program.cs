using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;
using Studentprogram;

public class Program
{
    public static void Main(string[] args)
    {
        //List<Student> students = new List<Student>();




        //students.Add(new Student(1, "ayush"));
        //students.Add(new Student(2, "manu"));
        //students.Add(new Student(3, "vishnu"));

        //var linqquery=from e in students
        //              where e.id == 2
        //              select e;

        //foreach (var st in linqquery) 
        //{ 
        //    Console.WriteLine(st.name );
        //}


        List<int> numbers = new List<int>()
        { 1,2,3,4,5,6,7,8,9,10};

        var linqq=numbers.Where(e=>e<=10 && e>=5 ).Select(e=>e);

        foreach(int i in linqq)
        {
            Console.WriteLine(i);
        }

       
        




        

        //var linquery = from e in numbers
        //               where e <= 10 && e >= 5
        //               select e;

        //foreach (var num in linquery)
        //{
        //    Console.WriteLine(num);
        //}



        //List<string> list = new List<string>()
        //{
        //    "hello","hii","imfine"
        //};

        //var linq=from e in list
        //         where e.Contains("e")
        //         select e;

        //foreach (var e in linq)
        //{
        //    Console.WriteLine(e);
        //}
       

        



     
        




    }
}