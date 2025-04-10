internal class Program
{
    private static void Main(string[] args)
    {
        const string correctPassword = "mypassword"; // Set the correct password
        int attempts = 0;
        const int maxAttempts = 3;
        string userInput;

        do
        {
            Console.Write("Enter password: ");
            userInput = Console.ReadLine();
            attempts++;

            if (userInput == correctPassword)
            {
                Console.WriteLine("Access granted!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        } while (attempts < maxAttempts);

        if (userInput != correctPassword)
        {
            Console.WriteLine("Too many failed attempts. Access denied.");
        }
    }
}