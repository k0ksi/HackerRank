using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    static void extraLongFactorials(int n)
    {
        BigInteger result = 1;
        BigInteger number = n;
        while (true)
        {
            if(n == 0)
            {
                break;
            }

            result *= n;
            n--;
        }

        Console.WriteLine(result);
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        extraLongFactorials(n);
    }
}
