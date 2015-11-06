using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is : {0}", firstNumber);
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is : {0}", secondNumber);
        }
        if (thirdNumber > secondNumber && thirdNumber > firstNumber)
        {
            Console.WriteLine("The biggest number is : {0}", thirdNumber);
        }
    }
}

