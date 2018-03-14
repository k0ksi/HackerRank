using System;
using System.Linq;

class Solution
{
    static string solve(int[] a)
    {
        bool exists = false;

        //var firstSum = 0;
        //var secondSum = 0;

        int sum = a.Sum();

        var currentSum = 0;

        if(a.Length == 1)
        {
            return "YES";
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (i == 44)
            {

            }
            var currentNum = a[i];
            currentSum += a[i];

            if (i == 0)
                continue;

            var newSum = sum - a[i];

            if(newSum / 2 == currentSum - currentNum)
            {
                exists = true;
                break;
            }
            
            //if(i == 0)
            //{
            //    continue;
            //}

            //if(firstSum == secondSum)
            //{
            //    exists = true;
            //    break;
            //}
        }

        return exists ? "YES" : "NO";
    }

    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < T; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string result = solve(a);
            Console.WriteLine(result);
        }
    }
}