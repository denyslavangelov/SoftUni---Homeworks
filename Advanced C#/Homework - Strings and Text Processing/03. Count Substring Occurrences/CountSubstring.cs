using System;
using System.Collections.Generic;

class CountSubstring
{
    static void Main()
    {
        // Input.
        string input = Console.ReadLine().ToLower();
        string element = Console.ReadLine();

        // Variables
        int counter = 0;
        string search;

        // Logic. Search thro the input lenght and find Substring which is equal to the element and put it in a counter variable;
        for (int i = 0; i < input.Length - element.Length + 1; i++)
        {
            search = input.Substring(i, element.Length);
            if (string.Equals(search, element))
            {
                counter++;
            }
        }

        // Output.
        Console.WriteLine(counter);
    }
}

