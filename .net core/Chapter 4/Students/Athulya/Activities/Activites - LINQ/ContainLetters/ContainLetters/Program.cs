namespace ContainLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string> { "dog", "cat", "tiger", "Elephant", "Zebra" };
            var x = from e in letters
                    where e.Contains("e")
                    select e;

            foreach(var y in x)
            {
                Console.WriteLine(y);
            }
        }
    }
}
