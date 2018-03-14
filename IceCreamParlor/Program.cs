using System;

class Solution
{
    static int[] icecreamParlor(int m, int[] arr)
    {
        var result = new int[2];

        for (int i = 0; i < arr.Length; i++)
        {
            var first = arr[i];

            for (int j = 1; j < arr.Length; j++)
            {
                if(i == j)
                {
                    continue;
                }

                var second = arr[j];

                if(first + second == m)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                }
            }
        }

        Array.Sort(result);

        return result;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = icecreamParlor(m, arr);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}