using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int getTotalX(int[] a, int[] b)
    {
        int min = b.Min();
        int number = 1;
        int resultCounter = 0;

        while (true)
        {
            int currentCount = 0;

            if (number > min)
            {
                break;
            }

            if(number == 16)
            {

            }

            for (int i = 0; i < a.Length; i++)
            {
                var num = a[i];
                if(number % num == 0)
                {
                    currentCount++;
                }
            }

            for (int k = 0; k < b.Length; k++)
            {
                var secondNum = b[k];
                if(secondNum % number == 0)
                {
                    currentCount++;
                }
            }

            if(currentCount == a.Length + b.Length)
            {
                resultCounter++;
            }

            number++;
        }

        return resultCounter;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
