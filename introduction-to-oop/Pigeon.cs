using System;
using System.Collections.Generic;
using System.Text;

namespace introduction_to_oop
{
    class Pigeon: Bird
    {
        public Pigeon(string name, string color): base(name, color)
        {

        }

        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }

        public void Sleep()
        {
            Console.WriteLine("Going to bed");
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }

        public override void Fly()
        {
            Console.WriteLine($"Whoops, I can't fly. Waddle waddle.");
        }
    }
}
