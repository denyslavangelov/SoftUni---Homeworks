using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Enter your second number : ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Your first number is : {0}", firstNumber);
        Console.WriteLine("Your second number is : {0}\n", secondNumber);

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine("The bigger number is : {0}", max);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        int getMax = Math.Max(firstNumber, secondNumber);
        return getMax;
    }
}
