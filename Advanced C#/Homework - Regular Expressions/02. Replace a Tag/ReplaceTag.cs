using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        // Input
        string inputString = @"<ul>
                                  <li>
                                      <a href=http://softuni.bg>SoftUni</a>
                                  </li>
                              </ul>";

        // Logic and output.
        string pattern = "<a(\\shref=.+)>(.+)<\\/a>";

        Console.WriteLine(Regex.Replace(inputString, pattern, @"[URL href=$1]$2[/URL]"));

    }
}

