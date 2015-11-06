using System;

class BiggestOf5Numbers
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
        Console.Write("Enter your fourth number : ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your fifth number : ");
        double fifthNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic No.2 and output.
        double maxNumber = firstNumber;

        if (maxNumber < secondNumber) 
        {
            maxNumber = secondNumber;
        }
        if (maxNumber < thirdNumber)
        {
            maxNumber = thirdNumber;
        }
        if (maxNumber < fourthNumber)
        {
            maxNumber = fourthNumber;
        }
        else
        {
            maxNumber = fifthNumber;
        }
        Console.WriteLine("The biggest number is : {0}", maxNumber);
       
    }
}

