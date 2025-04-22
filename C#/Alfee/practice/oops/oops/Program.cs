using oops;

internal class Program
{
    private static void Main(string[] args)
    {
        Fruit fruit1 = new Fruit();
        fruit1.Name = "apple";
        fruit1.color = "red";
        fruit1.display();

        Fruit fruit2 = new Fruit();
        fruit2.Name = "banana";
        fruit2.color = "yellow";
        fruit2.display();
    }
}