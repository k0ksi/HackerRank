using System;

class Solution
{

    static int activityNotifications(int[] expenditure, int d)
    {
        int startIndex = 0;

        int notificationsCount = 0;

        for (int i = d; i < expenditure.Length; i++)
        {
            int item = expenditure[i];
            int[] subArray = Extensions.SubArray<int>(expenditure, startIndex, d);

            Array.Sort(subArray);

            decimal median = i;

            if(d % 2 == 0)
            {
                median = (decimal)((subArray[d / 2 - 1] + subArray[d / 2]) / 2.0m);
            }
            else
            {
                median = subArray[d / 2];
            }

            if(i >= 2 * median)
            {
                notificationsCount++;
            }

            startIndex++;
        }

        return notificationsCount;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] expenditure_temp = Console.ReadLine().Split(' ');
        int[] expenditure = Array.ConvertAll(expenditure_temp, Int32.Parse);
        int result = activityNotifications(expenditure, d);
        Console.WriteLine(result);
    }
}

public static class Extensions
{
    public static T[] SubArray<T>(this T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }
}
