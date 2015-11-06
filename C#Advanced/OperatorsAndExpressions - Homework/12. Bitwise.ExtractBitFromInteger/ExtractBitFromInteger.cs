using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        // Input.
        Console.Write("Enter a number, please : ");
        int number = int.Parse(Console.ReadLine());
        string toBinary = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine("The number {0} to binary : {1}", number, toBinary);

        Console.WriteLine();
        Console.Write("Enter the position : ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine();


        // Logic.
        int checkPosition = (number >> position) & 1;

        // Output
        Console.WriteLine("The bit at the {0} position is : {1}.", position, checkPosition);
    }
}

