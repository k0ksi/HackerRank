using System;

class Solution
{

    static int findMedian(int[] arr)
    {
        Array.Sort(arr);

        int medianIndex = arr.Length / 2;

        return arr[medianIndex];
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int result = findMedian(arr);
        Console.WriteLine(result);
    }
}
