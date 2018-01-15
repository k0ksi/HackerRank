using System;

class Solution
{

    static int[] breakingRecords(int[] scores)
    {
        var minScore = scores[0];
        var maxScore = scores[0];

        var minCount = 0;
        var maxCount = 0;

        foreach (var score in scores)
        {
            if(score < minScore)
            {
                minCount++;
                minScore = score;
            }

            if(score > maxScore)
            {
                maxCount++;
                maxScore = score;
            }
        }

        return new int[] { maxCount, minCount };
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp, Int32.Parse);
        int[] result = breakingRecords(score);
        Console.WriteLine(String.Join(" ", result));
    }
}
