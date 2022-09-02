
using System;

namespace introduction_to_oop
{
    abstract class Bird: IDance
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public abstract void Speak();

        public virtual void Fly()
        {
            Console.WriteLine($"Hi there! I can fly.");
        }

        public void Spin()
        {
            Console.WriteLine($"{Name} spin!");
        }

        public void DoTheCaterpillar()
        {
            Console.WriteLine($"{Name} do the wriggly woo!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jump in the air!");
        }
    }
}