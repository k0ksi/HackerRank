using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int camelcase(string s)
    {
        var counter = 1;

        foreach (var ch in s)
        {
            if (char.IsUpper(ch))
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        int result = camelcase(s);
        Console.WriteLine(result);
    }
}
