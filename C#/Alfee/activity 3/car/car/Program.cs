internal class Program
{
    enum FuelType
    {
        Petrol,
        Diesel,
        Electric
    }

    struct Car
    {
        public string Brand;
        public int Year;
        public FuelType Fuel;

        public Car(string brand, int year, FuelType fuel)
        {
            Brand = brand;
            Year = year;
            Fuel = fuel;
        }

       
        public void DisplayDetails()
        {
            Console.WriteLine($"Car Brand: {Brand}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Fuel Type: {Fuel}");
        }
    }
    static void Main()
    {
       
        Car myCar = new Car("Swift", 2022, FuelType.Petrol);

       
        myCar.DisplayDetails();

        Console.ReadLine();
    }

}