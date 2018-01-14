using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void plusMinus(int[] arr)
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroesCount = 0;

        foreach (var num in arr)
        {
            if(num == 0)
            {
                zeroesCount++;
            }
            else
            {
                if(num > 0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
        }

        decimal positiveFraction = (decimal)positiveCount / (decimal)arr.Length;
        decimal negativeFraction = (decimal)negativeCount / (decimal)arr.Length;
        decimal zeroesFraction = (decimal)zeroesCount / (decimal)arr.Length;

        Console.WriteLine(positiveFraction);
        Console.WriteLine(negativeFraction);
        Console.WriteLine(zeroesFraction);
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        plusMinus(arr);
    }
}
