using System;

class BiggestOf3Numbers
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();


        // Logic and output.
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is : {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is : {0}", secondNumber);
        }

        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("The biggest number is : {0}", thirdNumber);
        }
    }
}

