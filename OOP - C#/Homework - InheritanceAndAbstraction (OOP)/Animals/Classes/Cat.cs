using System;
using Animals.Interfaces;

namespace Animals
{
    public class Cat : Animal, ISoundProducible
    {
        public Cat(string name, string gender, int age)
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Cat : Mrrrr.");
        }
    }
}
