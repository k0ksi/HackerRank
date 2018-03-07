using System;
using System.Collections.Generic;

class Solution
{

    static void closestNumbers(int[] arr)
    {
        int min = 0;
        int temp = 0;
        Dictionary<int, List<int>> minMap = new Dictionary<int, List<int>>();

        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++)
        {
            temp = arr[i + 1] - arr[i];
            if(!minMap.ContainsKey(temp))
                minMap.Add(temp, new List<int>());

            minMap[temp].Add(arr[i]);
            minMap[temp].Add(arr[i+1]);
            if(min > temp || i == 0)
            {
                min = temp;
            }
        }

        for (int i = 0; i < minMap[min].Count; i++)
        {
            Console.Write(minMap[min][i] + " ");
        }
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        closestNumbers(arr);
    }
}
