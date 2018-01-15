using System;

class Solution
{

    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int counter = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            var first = ar[i];
            for (int j = i + 1; j < ar.Length; j++)
            {
                var second = ar[j];
                if((first + second) % k == 0) 
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}
