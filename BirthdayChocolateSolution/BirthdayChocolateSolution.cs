using System;
using System.Linq;

class Solution
{

    static int solve(int n, int[] s, int d, int m)
    {
        int[] chocolates = s;
        int counter = 0;
        for (int i = 0; i < chocolates.Length; i++)
        {
            var num = chocolates
                .Skip(i)
                .Take(m);

            if(num.Sum() == d)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');

        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}
