using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Blueprint
{
    internal class House
    {
        public string Color;
        public int NumberOfRooms;
        public bool HasGarage;

        public House(string color, int numberOfRooms, bool hasGarage)
        {
            Color = color;
            NumberOfRooms = numberOfRooms;
            HasGarage = hasGarage;
        }

        public void ShowInfo()
        {
            Console.WriteLine("House Information:");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Number of Rooms: {NumberOfRooms}");
            Console.WriteLine($"Has Garage: {(HasGarage ? "Yes" : "No")}");
            Console.WriteLine("------------------------");
        }
    }
}
