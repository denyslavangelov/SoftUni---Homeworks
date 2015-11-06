using System;

class QuotesInStrings
{
    static void Main()
    {
        string escaped = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";
        
        // Output
        Console.WriteLine("{0}", escaped);

        Console.WriteLine();

        Console.WriteLine("{0}", quoted);
    }
}

