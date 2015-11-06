using System;

class ThreeNumbersWithNestedIFs
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

        // Logic and output.
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }  
        }
        
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
        }

        else 
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }


        
    }
}

