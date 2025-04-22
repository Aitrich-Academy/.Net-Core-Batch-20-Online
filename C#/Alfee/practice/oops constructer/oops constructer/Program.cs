using oops_constructer;

internal class Program
{
    private static void Main(string[] args)
    {
        Friuts friut1 = new Friuts("apple","red");
        friut1.display();

        Friuts friut2 = new Friuts("banana", "yellow");
        friut2.display();

        Friuts friut3 = new Friuts("orange", "orange");
        friut3.display();


    }
}