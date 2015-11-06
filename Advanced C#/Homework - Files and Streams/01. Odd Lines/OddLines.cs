using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        try
        {
            // Input.
            StreamReader reader = new StreamReader(@"..\..\OddLines.cs", Encoding.GetEncoding("windows-1251"));

            string s;
            int lineNumber = 0;

            // Logic.
            using (reader)
            {
                do
                {
                    s = reader.ReadLine();
                    lineNumber++;
                    s = reader.ReadLine();
                    Console.WriteLine("Line {0, 2}: {1}", lineNumber, s);
                    lineNumber++;
                } while (s != null);
            }
        }

        // If there is no file found.
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}
