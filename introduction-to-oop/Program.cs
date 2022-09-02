using System;

namespace introduction_to_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bird = new Bird("Tweety", "Yellow");
            //bird.Speak();
            //bird.Fly();

            var pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();
        }
    }
}
