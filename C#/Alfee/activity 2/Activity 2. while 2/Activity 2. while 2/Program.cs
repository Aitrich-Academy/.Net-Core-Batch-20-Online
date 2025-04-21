internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); string correctPassword = "securePass123"; // Set the correct password
        int maxAttempts = 3;
        int attempts = 0;

        while (attempts < maxAttempts)
        {
            Console.Write("Enter your password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                continue;
            }

            if (enteredPassword == correctPassword)
            {
                Console.WriteLine("Login successful! Welcome.");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect password. Attempts remaining: " + (maxAttempts - attempts));
            }
        }

        Console.WriteLine("Too many failed attempts. You are locked out.");
    }
}