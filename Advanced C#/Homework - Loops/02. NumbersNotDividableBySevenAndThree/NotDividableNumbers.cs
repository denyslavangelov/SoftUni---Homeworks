using System;

class NotDividableNumbers
{
    static void Main()
    {
        // Input.
        Console.Write("Please enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic and output.
        for (int i = 1; i <= number; i++)
        {
            if (!(i % 3 == 0 || i % 7 == 0))
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }
}

