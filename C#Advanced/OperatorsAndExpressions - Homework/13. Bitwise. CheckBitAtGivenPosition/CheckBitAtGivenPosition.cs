using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        // Input.
        Console.Write("Please enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();
        
        string numberAsBinary = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.Write("The number {0} converted in Binary : {1}",number, numberAsBinary);

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter a position to check : ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic.
        int bitAtPosition = (number >> position) & 1;
        bool isItOne = bitAtPosition == 1;

        // Output.

        Console.WriteLine("The digit at position {0} is One : {1}", position, isItOne);

    }
}

