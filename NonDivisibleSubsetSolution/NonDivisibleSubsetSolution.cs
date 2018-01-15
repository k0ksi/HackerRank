using System;
using System.Collections.Generic;

class Solution
{
    // TODO Understand
    static int nonDivisibleSubset(int k, int[] arr)
    {        
        int[] cnts = new int[k];
        for (int a_i = 0; a_i < arr.Length; a_i++)
        {
            cnts[arr[a_i] % k]++;
        }
        int cnt = 0;
        for (int i = 1; i <= k / 2; i++)
        {
            if (2 * i != k)
            {
                cnt += Math.Max(cnts[i], cnts[k - i]);
            }
        }
        if (k % 2 == 0)
        {
            if (cnts[k / 2] > 0)
            {
                cnt++;
            }
        }
        if (cnts[0] > 0)
        {
            cnt++;
        }

        return cnt;
    }

    static bool CheckIfItsNotDivisible(List<int> nums, int divisible)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = i; j < nums.Count; j++)
            {
                if ((nums[i] + nums[j]) % divisible == 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int result = nonDivisibleSubset(k, arr);
        Console.WriteLine(result);
    }
}

//List<int> nums = new List<int>();

            //for (int j = 0; j<n; j++)
            //{
            //    if((i & (1 << j)) > 0)
            //    {
            //        //nums.Add(arr[j]);
            //        currentMax++;
            //    }                
            //}

            //if (nums.Count > 0)
            //{
            //    bool isntDivisible = CheckIfItsNotDivisible(nums, k);
            //    currentMax = nums.Count;
            //    if (currentMax > maxSubSetCount && isntDivisible)
            //    {
            //        maxSubSetCount = currentMax;
            //    }
            //}