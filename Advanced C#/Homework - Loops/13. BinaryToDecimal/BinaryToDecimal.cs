using System;

class BinaryToDecimal
{
    static void Main()
    {
        // Input
        Console.Write("Enter a number in Binary format : ");
        string binaryNumber = Console.ReadLine();

        // Logic
        long result = 0;
        int power = 1;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int number = binaryNumber[i] - '0';
            result += number * power;
            power *= 2;
        }

        // Output
        Console.WriteLine("Your number in decimal format : {0}", result);
    }
}