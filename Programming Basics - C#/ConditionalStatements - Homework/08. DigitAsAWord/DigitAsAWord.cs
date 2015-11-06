using System;

class DigitAsAWord
{
    static void Main()
    {
        // Input
        Console.Write("Please enter a digit (from 1 - 9) : ");
        string digit = Console.ReadLine();

        Console.WriteLine();

        // Check if digit. Logic and output.
        int n;
        bool isDigit = int.TryParse(digit, out n);

        if (isDigit)
        {
            int intDigit = int.Parse(digit);

            switch (intDigit)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break;
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                default: Console.WriteLine("Not a digit!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Not a digit!");
        }
    }
}

