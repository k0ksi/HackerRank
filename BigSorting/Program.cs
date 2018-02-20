using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

class Solution
{

    static string[] bigSorting(string[] arr)
    {
        Array.Sort(arr);



        return arr;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for (int arr_i = 0; arr_i < n; arr_i++)
        {
            arr[arr_i] = (Console.ReadLine());
        }
        Array.Sort(arr, new CustomComparer());
        Console.WriteLine(String.Join("\n", arr));
    }
}

class CustomComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x.Length < y.Length)
            return -1;
        else if (x.Length > y.Length)
        {
            return 1;
        }
        else
        {
            if (x == y)
                return 0;
            else
            {
                var i = 0;
                while (x[i] == y[i]) i++;
                return x[i].CompareTo(y[i]);
            }
        }
    }
}
