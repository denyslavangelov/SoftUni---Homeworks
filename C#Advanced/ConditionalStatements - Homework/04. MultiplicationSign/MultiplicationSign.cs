using System;

class MultiplicationSign
{
    static void Main()
    {
        // Input
        Console.Write("Enter your first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic and output.
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The multiplication sign is : '0' "); ;
        }
        else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0))
        {
            Console.WriteLine("The multiplication sign is : '+' ");
        }
        else
        {
            Console.WriteLine("The multiplication sign is : '-' ");
        }
    }
}

