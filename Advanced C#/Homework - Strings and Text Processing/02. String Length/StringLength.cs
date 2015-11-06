using System;

class StringLength
{
    static void Main()
    {
        // Input.
        string inputString = Console.ReadLine().Trim();
        string outputString = null;

        // Logic
        if (inputString.Length > 20)
        { 
           outputString = inputString.Substring(0, 20);
        }
        else
        {
           outputString = inputString.PadRight(20, '*');
        }

        // Output.
        Console.WriteLine(outputString);


    }
}

