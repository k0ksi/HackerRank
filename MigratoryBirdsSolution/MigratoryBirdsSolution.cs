using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static int migratoryBirds(int n, int[] ar)
    {
        Array.Sort(ar);
        int max = int.MinValue;
        int currentMax = 1;
        int result = 1;

        for (int i = 1; i < ar.Length; i++)
        {
            var birdType = ar[i];
            var prevBirdType = ar[i - 1];
            if (prevBirdType == birdType)
            {
                currentMax++;
                if (currentMax > max)
                {
                    max = currentMax;
                    result = birdType;
                }
            }
            else
            {
                currentMax = 1;
            }
        }

        return result;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
