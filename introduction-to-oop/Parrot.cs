using System;
using System.Collections.Generic;
using System.Text;

namespace introduction_to_oop
{
    class Parrot : Bird
    {

        public Parrot(string name, string color): base(name, color)
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Hi! I am Parrot and I can speak Humans");
        }
    }
}
