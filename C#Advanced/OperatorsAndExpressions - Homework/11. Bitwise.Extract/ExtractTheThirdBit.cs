using System;

class ExtractTheThirdBit
{
    static void Main()
    {
        // Input.
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Number to Binary : ");

        string toBinary = Convert.ToString(number, 2).PadLeft(16,'0');
        Console.WriteLine(toBinary);

        // Logic.
        int moveTheBit = (number >> 3) & 1;

        Console.WriteLine();
        
        // Output.
        Console.WriteLine("The third bit is : {0}", moveTheBit);
    }
}

