using System;

class OddOrEvenProduct
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your numbers splited with spaces : ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        // Variables
        int oddProduct = 1;
        int evenProduct = 1;

        // Loop, logic and output!
        for (int i = 0; i < inputArray.Length; i++)
        {
            int number = int.Parse(inputArray[i]);

            if (i % 2 == 0 || i == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("Rroduct = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No!");
            Console.WriteLine("Odd product = {0}", oddProduct);
            Console.WriteLine("Even product = {0}", evenProduct);
        }
    }
}

