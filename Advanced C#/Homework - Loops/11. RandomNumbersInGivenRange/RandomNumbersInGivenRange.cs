using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        // Input.
        Console.Write("Enter how much random numbers you want the program to produce : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the Min number : ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter the Max number : ");
        int max = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Random randomNumber = new Random();

        // Logic and output.
        if (min <= max)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}" + " ", randomNumber.Next(min, max + 1));
            }
        }
        else
        {
            Console.WriteLine("Min should be less or equal to Max!");
        }

        Console.WriteLine();
    }
}

