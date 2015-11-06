using System;

class NumbersFromOneToN
{
    static void Main()
    {

        // Input.
        int number = int.Parse(Console.ReadLine());

        // Counter variable.
        int counter = 1;

        // Logic and output using Loop.
        while (counter <= number)
        {
            Console.Write("{0} ", counter);
            counter++;
        }

        Console.WriteLine();
    }
}

