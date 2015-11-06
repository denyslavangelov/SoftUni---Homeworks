using System;

class ExchangeVariableValues
{
    static void Main()
    {
        // Ouput
        int a = 5;
        int b = 10;
        Console.WriteLine("Before : \n a = {0} b = {1}", a, b);


        Console.WriteLine();

        // Switched
        b = 5;
        a = 10;
        Console.WriteLine("After : \n a = {0} b = {1}", a, b);
    }
}

