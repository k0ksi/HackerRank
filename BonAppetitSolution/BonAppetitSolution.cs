using System;

class Solution
{

    static int bonAppetit(int n, int k, int b, int[] ar)
    {
        int sharedItemsCost = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if(i != k)
            {
                sharedItemsCost += ar[i];
            }
        }

        int half = sharedItemsCost / 2;
        int annasBill = (sharedItemsCost + ar[k]) / 2 - half;
        if(half == b)
        {
            Console.WriteLine("Bon Appetit");
            annasBill = 0;
        }

        return annasBill;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int b = Convert.ToInt32(Console.ReadLine());
        int result = bonAppetit(n, k, b, ar);

        if(result != 0)
        {
            Console.WriteLine(result);
        }
    }
}
