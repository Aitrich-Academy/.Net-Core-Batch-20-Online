internal class Program
{
    private static void Main(string[] args)
    {
        string[][] programs = new string[3][];

        programs[0] = new string[] { "HTML", "CSS" }; 
        programs[1] = new string[] { "Javascript", "Bootstrap", "C#" }; 
        programs[2] = new string[] { "Python" };

        for (int i = 0; i < programs.Length; i++)
        {
            for (int j = 0; j < programs[i].Length; j++)
            {
                Console.Write(programs[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}