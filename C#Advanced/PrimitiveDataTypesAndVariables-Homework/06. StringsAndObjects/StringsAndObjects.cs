using System;

class StringsAndObjects
{
    static void Main()
    {   
        string firstString = "Hello";
        string secondString = "World!";

        object concatenation = firstString + " " + secondString;

        string result = (string)concatenation;

        // Output
        Console.WriteLine("{0}", result);
    }
}

