using System;
using Animals.Interfaces;

namespace Animals
{
    public class Dog : Animal, ISoundProducible
    {
        public Dog(string name, string gender, int age)
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Dog: Baaark.");
        }
    }
}
