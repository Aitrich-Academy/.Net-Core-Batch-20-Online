using System;

namespace CarProgram
{
    // Define the FuelType enum
    enum FuelType
    {
        Petrol,
        Diesel,
        Electric
    }

    // Define the Car struct
    struct Car
    {
        public string Brand;
        public int Year;
        public FuelType Fuel;

        // Method to display car details
        public void PrintDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Fuel Type: {Fuel}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a Car object
            Car myCar;
            myCar.Brand = "Tesla";
            myCar.Year = 2023;
            myCar.Fuel = FuelType.Electric;

            // Print the car's details
            myCar.PrintDetails();

            Console.ReadLine(); // To keep the console window open
        }
    }
}
