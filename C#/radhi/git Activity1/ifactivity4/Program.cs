internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        char ch = (char)Console.Read();





        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine($"'{ch}' is an alphabet.");
            }
            else
            {
                Console.WriteLine($"'{ch}' is not an alphabet.");
            }
        
    }
}