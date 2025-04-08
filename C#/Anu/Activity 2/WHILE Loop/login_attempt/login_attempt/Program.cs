internal class Program
{
    private static void Main(string[] args)
    {
        string correctPassword = "mypassword123";  
        int attempts = 0;
        int maxAttempts = 3;
        bool isAuthenticated = false;

        while (attempts < maxAttempts && !isAuthenticated)
        {
            Console.Write("Enter your password: ");
            string inputPassword = Console.ReadLine();

            // Validate password length
            if (inputPassword.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                continue; // Skip the rest of the loop and prompt again
            }

            if (inputPassword == correctPassword)
            {
                Console.WriteLine("Login successful!");
                isAuthenticated = true;
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect password. Attempts remaining: " + (maxAttempts - attempts));
            }
        }

        if (!isAuthenticated)
        {
            Console.WriteLine("Too many failed attempts. You are locked out.");
        }
    }
}