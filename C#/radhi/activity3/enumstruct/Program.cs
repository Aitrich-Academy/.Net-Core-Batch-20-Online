using System.ComponentModel;
using System.Runtime.InteropServices;
public enum FuelType
{
    petrol,
    diesal,
    electonic,
}

internal class Program
{
    public struct Car
    {
        public string Brand;
        public int Year;
        FuelType Type;


        public Car(string brand, int year, FuelType type)
        {
            Brand = brand;
            Year = year;
            Type = type;

        }

        public void display()
        {
            Console.WriteLine($"Brand:{Brand} \n Year:{Year} \n Type:{Type} ");
        }
    }



    private static void Main(string[] args)
    {
        //Define a struct called Car with:Brand(string)Year(int)FuelType(enum with values: Petrol, Diesel, Electric)
        //Write a program to create a car object, assign values, and print its details

        Car car = new Car("Maruthi", 2014, FuelType.petrol);
        car.display();
    }
        










}
