using System;
using System.Collections.Generic;

class Solution
{

    static int[] countingSort(int[] arr)
    {
        int[] occurences = new int[100];

        foreach (var item in arr)
        {
            occurences[item]++;
        }

        List<int> result = new List<int>();

        for (int i = 0; i < occurences.Length; i++)
        {
            int count = occurences[i];

            for (int j = 0; j < count; j++)
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int[] result = countingSort(arr);
        Console.WriteLine(String.Join(" ", result));


    }
}
