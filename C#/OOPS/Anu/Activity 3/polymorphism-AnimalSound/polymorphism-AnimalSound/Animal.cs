using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_AnimalSound
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }

       public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Woof");
            }
        }

        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Meow");
            }
        }
    }
}
