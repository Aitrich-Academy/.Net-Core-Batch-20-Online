namespace FindSpecificElementLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integer = new List<int>();
            integer.Add(150);
            integer.Add(90);
            integer.Add(110);
            integer.Add(200);
            integer.Add(500);
            var query = from e in integer
                        where e > 50
                        select e;
            foreach(var e in query)
            {
                Console.WriteLine(e);
            }
            var methodsytaxQuery = integer.Where(e => e > 50).Select(e => e);
            
            foreach (var y in methodsytaxQuery)
            {
                Console.WriteLine("display other method");
                Console.WriteLine(y);
            }
        }
    }
}
