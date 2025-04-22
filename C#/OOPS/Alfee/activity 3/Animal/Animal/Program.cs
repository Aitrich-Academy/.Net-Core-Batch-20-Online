using Animal_oops;
internal class Program
{
    public static void Main(string[] args)
    {
        Animal myAnimal;

        myAnimal = new Dog();
        myAnimal.Speak(); 

        myAnimal = new Cat();
        myAnimal.Speak();
    }
}