using System;

class Solution
{

    static int[] countingSort(int[] arr)
    {
        int[] occurences = new int[100];

        foreach (var item in arr)
        {
            occurences[item]++;
        }

        return occurences;
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
