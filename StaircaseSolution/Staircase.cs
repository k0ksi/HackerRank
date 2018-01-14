using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            string spaces = new string(' ', n - i - 1);
            string diez = new string('#', i + 1);
            Console.WriteLine(spaces + diez);
        }
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
