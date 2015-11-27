using System;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name,int age, string gender = maleGender)
            : base(name, gender, age)
        {
        }

        public new static void ProduceSound()
        {
            Console.WriteLine("Tomcat: Mr!");
        }
    }
}
