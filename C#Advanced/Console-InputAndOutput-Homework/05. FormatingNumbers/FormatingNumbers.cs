using System;

class FormatingNumbers
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        string toBinary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
       
        Console.Write("Enter your second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
       
        Console.Write("Enter your third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();

        // Output
        Console.WriteLine("|{0, -10:X}|{1}|{2, 10:0.00}|{3, -10:0.000}|", firstNumber, toBinary, secondNumber, thirdNumber);
    }
}

