using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        // Input
        Console.Write("Enter a number for A : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for B : ");
        int b = int.Parse(Console.ReadLine());

        // Logic.
        int biggerNumber = Math.Max(Math.Abs(a), Math.Abs(b));
        int smallerNumber = Math.Min(Math.Abs(a), Math.Abs(b));

        int remainder = biggerNumber - smallerNumber;

        while (remainder > 0)
        {
            while (remainder > smallerNumber)
            {
                remainder -= smallerNumber;
            }

            biggerNumber = smallerNumber;
            smallerNumber = remainder;
            remainder = biggerNumber - smallerNumber;
        }

        // Output.
        Console.WriteLine("\nThe greatest common divisor (GCD) of {0} and {1} is: {2}.\n", a, b, smallerNumber);
    }
}
