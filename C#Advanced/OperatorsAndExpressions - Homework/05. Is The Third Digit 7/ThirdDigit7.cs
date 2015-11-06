using System;

class ThirdDigit7
{
    static void Main()
    {
        // Input.
        Console.Write("Enter a number to check if the third digit is 7 : ");
        int number = int.Parse(Console.ReadLine());

        //Logic
        int findNumber = (number / 100) % 10;
        bool isItSeven = findNumber == 7;

        Console.WriteLine();

        // Output
        Console.WriteLine("The third digit of the number {0} is Seven : {1}", number, isItSeven);
    }
}

