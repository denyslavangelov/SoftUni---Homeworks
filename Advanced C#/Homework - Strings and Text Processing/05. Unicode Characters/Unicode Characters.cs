using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        // Input.
        string inputString = Console.ReadLine();

        // Logic and output.
        foreach (var unicode in inputString)
        {
            Console.Write("\\u" + "{0:x4}", (int) unicode);
        }

        Console.WriteLine();

        // Using string builder.

        //string input = Console.ReadLine();

        //StringBuilder sb = new StringBuilder();
        //foreach (var unicode in input)
        //{
        //    sb.Append("\\u");
        //    sb.Append(String.Format("{0:x4}", (int)unicode)); ;
        //}
        //Console.WriteLine(sb.ToString());


    }
}

