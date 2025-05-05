using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayList array = new ArrayList();
//       

        SortedList jobs = new SortedList();
        jobs.Add("Software Developer",1);
        jobs.Add("Web Designer",2);
        jobs.Add("Database Administrator",3);
        
        Console.WriteLine("List of jobs in sortedlist");
        jobs.Remove("Database Administrator");
      foreach(var job in jobs.Keys) {
            {

                Console.WriteLine($"{job} : {jobs[job]}");
            }
         
        }
       
    }
}