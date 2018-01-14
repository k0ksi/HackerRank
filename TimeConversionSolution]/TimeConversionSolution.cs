using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string timeConversion(string s)
    {
        var tokens = s.Split(':');
        var hour = string.Empty;
        var isPm = tokens[tokens.Length - 1].EndsWith("PM");
        if (isPm)
        {
            hour = (int.Parse(tokens[0]) + 12).ToString();
            if(hour == "24")
            {
                hour = "12";
            }
        }
        else
        {
            hour = tokens[0];
        }

        hour = (hour == "12" && !isPm) ? "00" : hour;

        return hour + ":" + tokens[1] + ":" + tokens[2].Substring(0, 2);
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
