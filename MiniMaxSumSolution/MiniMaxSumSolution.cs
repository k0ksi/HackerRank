using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void miniMaxSum(int[] arr)
    {
        long firstSum = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[4];
        long secondSum = (long)arr[0] + (long)arr[2] + (long)arr[3] + (long)arr[4];
        long thirdSum = (long)arr[0] + (long)arr[1] + (long)arr[3] + (long)arr[4];
        long fourthSum = (long)arr[1] + (long)arr[2] + (long)arr[0] + (long)arr[4];
        long fifthSum = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[0];

        long[] sums = new long[5];
        sums[0] = firstSum;
        sums[1] = secondSum;
        sums[2] = thirdSum;
        sums[3] = fourthSum;
        sums[4] = fifthSum;
        Array.Sort(sums);

        Console.WriteLine(sums[0] + " " + sums[4]);
    }

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        miniMaxSum(arr);
    }
}
