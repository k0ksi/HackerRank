using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int[] missingNumbers(int[] arr, int[] brr)
    {
        var distinct = new HashSet<int>();

        var firstDict = new Dictionary<int, int>();
        var secondDict = new Dictionary<int, int>();

        foreach (var item in arr)
        {
            distinct.Add(item);

            if(firstDict.ContainsKey(item))
            {
                firstDict[item]++;
            }
            else
            {
                firstDict.Add(item, 1);
            }
        }

        foreach (var item in brr)
        {
            distinct.Add(item);

            if (secondDict.ContainsKey(item))
            {
                secondDict[item]++;
            }
            else
            {
                secondDict.Add(item, 1);
            }
        }

        var missing = new HashSet<int>();

        foreach (var item in distinct)
        {
            if(firstDict[item] != secondDict[item])
            {
                missing.Add(item);
            }
        }

        var result = missing.ToArray();

        Array.Sort(result);

        return result;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int m = Convert.ToInt32(Console.ReadLine());
        string[] brr_temp = Console.ReadLine().Split(' ');
        int[] brr = Array.ConvertAll(brr_temp, Int32.Parse);
        int[] result = missingNumbers(arr, brr);
        Console.WriteLine(String.Join(" ", result));
    }
}