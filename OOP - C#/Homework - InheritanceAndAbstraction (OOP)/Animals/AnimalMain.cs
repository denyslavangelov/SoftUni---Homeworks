using System;
using System.Linq;

namespace Animals
{
    class AnimalMain
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Tomcat("Deni", 18),
                new Dog("Sharo", "male", 9),
                new Frog("Jabok", "female", 22),
                new Tomcat("Jerry", 23),
                new Tomcat("Tom", 10),
                new Frog("Jaborana", "male", 10),
                new Dog("Vandal", "male", 7),
                new Kitten("Anabelle", 28)
            };

            var dogsAverageAge = animals.Where(x => x is Dog).Average(x => x.Age);
            Console.WriteLine("The average age of all dogs is: {0}", dogsAverageAge);

            var frogsAverageAge = animals.Where(x => x is Frog).Average(x => x.Age);
            Console.WriteLine("The average age of all frogs is: {0}", frogsAverageAge);

            var kittensAverageAge = animals.Where(x => x is Kitten).Average(x => x.Age);
            Console.WriteLine("The average age of all Kittens is: {0}", kittensAverageAge);

            var tomcatsAverageAge = animals.Where(x => x is Tomcat).Average(x => x.Age);
            Console.WriteLine("The average age of all Tomcats is: {0}", tomcatsAverageAge);
        }
    }
}
