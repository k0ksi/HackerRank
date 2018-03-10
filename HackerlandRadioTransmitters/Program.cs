using System;
using System.Linq;

class Solution
{
    static int hackerlandRadioTransmitters(int[] x, int k)
    {
        int n = x.Length;

        Array.Sort(x);
        int i = 0;
        int count = 0;
        while (i < n - 1)
        {
            i = observe(i, x, k);
            count++;
        }
        if (i == n - 1) count++;

        return count;
    }


    private static int observe(int ind, int[] x, int k)
    {
        int j = ind + 1;
        while (x[j] - x[ind] <= k)
        {
            j++;
            if (j == x.Length)
            {
                return x.Length;
            }
        }
        int t = j;
        while (x[t] - x[j - 1] <= k)
        {
            t++;
            if (t == x.Length)
            {
                return x.Length;
            }
        }
        return t;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] x_temp = Console.ReadLine().Split(' ');
        int[] x = Array.ConvertAll(x_temp, Int32.Parse);
        int result = hackerlandRadioTransmitters(x, k);
        Console.WriteLine(result);
    }
}
