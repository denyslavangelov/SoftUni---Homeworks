using System;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender = femaleGender)
            : base(name, gender, age)
        {
        }

        public new void ProduceSound()
        {
            Console.WriteLine("Kitten: Sexier .. Mrrrr.");
        }
    }
}
