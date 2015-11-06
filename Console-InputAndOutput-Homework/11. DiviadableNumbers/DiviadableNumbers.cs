using System;

class DiviadableNumbers
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your first number : ");
        int startingNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter your second number : ");
        int endingNumber = int.Parse(Console.ReadLine());

        //Spaces.
        Console.WriteLine();

        // Logic.
        int counter = 0;
        for (int i = startingNumber; i <= endingNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Number devided by 5 : {0}", i);
                counter++;
            }
        }


        // Spaces.
        Console.WriteLine();


        // Output
        Console.WriteLine("There are {0} numbers dividable by 5 with reminder 0 in the interval {1} and {2}.", counter, startingNumber, endingNumber);

    }
}

