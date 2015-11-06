using System;

class DivideBy7And5
{
    static void Main()
    {
        // Input.
        Console.Write("Enter a number, please : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic.
        bool result = number % 7 == 0 && number % 5 == 0;

        // Output.
        Console.WriteLine("The number {0} can be divided by 7 or 5 : {1}", number, result);
    }
}

