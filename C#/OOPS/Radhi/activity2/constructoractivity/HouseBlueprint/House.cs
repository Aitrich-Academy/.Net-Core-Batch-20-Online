using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBlueprint
{
    public class House
    {
//        House Blueprint
//Objective: Apply object creation with custom data using constructors.

//Create a class House with:
//Properties: Color, NumberOfRooms, HasGarage
//Constructor to initialize all properties
//Method ShowInfo()
//Create and display 3 house objects with different values.
        public string Clr;
        public int NumberOfRooms;
        public string HasGarage;
        public House(string colr,int numberofrooms,string hasgarage)
        {
            Clr = colr;
            NumberOfRooms = numberofrooms;
            HasGarage = hasgarage;
        }
        public void Showinfo()
        {
           Console.WriteLine($"color:{Clr} \n Number Of Rooms:{NumberOfRooms} \n HasGarage:{HasGarage}");

        }

        

        }


    }

