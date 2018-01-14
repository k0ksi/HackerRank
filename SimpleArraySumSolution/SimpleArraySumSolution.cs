using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int simpleArraySum(int n, int[] ar)
    {
        int sum = 0;
        foreach (var item in ar)
        {
            sum += item;
        }

        return sum;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
