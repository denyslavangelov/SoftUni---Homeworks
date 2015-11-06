using System;

class OddOrEven
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        // Logic.
        bool isEven = number % 2 == 0;

        // Output
        Console.WriteLine("The number {0} is EVEN : {1}", number, isEven);
    }

}