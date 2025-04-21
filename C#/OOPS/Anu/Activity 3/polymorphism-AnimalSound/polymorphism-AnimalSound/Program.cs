using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static polymorphism_AnimalSound.Animal;

namespace polymorphism_AnimalSound
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();   
            Animal myCat = new Cat();


            myAnimal.Speak();  
            myDog.Speak();     
            myCat.Speak();      
        }
    }
}
