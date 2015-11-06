using System;
using System.IO;
using System.Text;

 class LineNumbers
 {
     static void Main(string[] args)
     {
         StreamReader reader = null;
         StreamWriter writer = null;
 
         // Open the current file.
         try
         {
             reader = new StreamReader(@"..\..\LineNumbers.cs", Encoding.GetEncoding("windows-1251"));
         }
         catch (FileNotFoundException)
         {
             Console.WriteLine("File not found.");
         }
 
         // Creates an output file.
         try
         {
             writer = new StreamWriter(@"..\..\LineNumbers.txt");
         }
         catch (IOException)
         {
             Console.WriteLine("Unable to create output file.");
         }
 
 
         string s;
         int lineNumber = 1;
         using (reader)
         using (writer)
         {
             do // Logic. Inserts the number of each line at the begining of every row.
             {
                 s = reader.ReadLine();
                 writer.WriteLine("{0} {1}", lineNumber, s);
                 lineNumber++;
             } while (s != null);
         }
         Console.WriteLine("Task complete:\n");
 
         // Print output.
         string fileContents = File.ReadAllText(@"..\..\LineNumbers.txt");
         Console.WriteLine(fileContents);
     }
 }