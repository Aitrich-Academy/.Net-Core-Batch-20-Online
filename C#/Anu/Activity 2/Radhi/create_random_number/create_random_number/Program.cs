internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Generates a number between 1 and 100
        int userGuess;

        Console.WriteLine("Guess the number between 1 and 100:");

        do
        {
            Console.Write("Enter your guess: ");
            while (!int.TryParse(Console.ReadLine(), out userGuess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter your guess: ");
            }

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
        } while (userGuess != randomNumber);

        Console.WriteLine("Congratulations! You guessed the correct number.");
    }
}