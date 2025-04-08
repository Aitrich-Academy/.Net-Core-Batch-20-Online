internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a character :");
        char ch = Convert.ToChar(Console.ReadLine());

        if(ch=='a' ||  ch=='e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("The character is vowel.");
        }
        else
        {
            Console.WriteLine("The character is not vowel.");
        }
    }
}