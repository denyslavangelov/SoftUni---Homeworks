using System;
using Animals.Interfaces;

namespace Animals
{
    public class Frog : Animal, ISoundProducible
    {
        public Frog(string name, string gender, int age)
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Frog: Kvak?");
        }
    }
}
