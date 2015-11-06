using System;

class ModifiyBitAtPosition
{
    static void Main()
    {
        // Input.
        Console.Write("Please enter a number : ");
        int number = int.Parse(Console.ReadLine());
        string numberAsString = Convert.ToString(number, 2);

        Console.WriteLine();

        Console.Write("Please enter a value : ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Please enter a position : ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic and output.
        int bitAtPosition = (number >> position) & 1;

        if (value == 1)
        {
            int setOne = 1 << position;
            int foundBitOne = number | setOne;
            Console.WriteLine(foundBitOne);
        }
        else
        {
            int setZero = ~(1 << position);
            int foundbitZero = number & setZero;
            Console.WriteLine(foundbitZero);
        }
    }
}

