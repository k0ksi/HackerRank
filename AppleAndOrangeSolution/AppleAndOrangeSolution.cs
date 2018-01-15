using System;

class Solution
{

    static int[] appleAndOrange(int s, int t, int a, int b, int[] apple, int[] orange)
    {
        int appleTree = a;
        int orangeTree = b;

        int applesCount = 0;
        int orangeCount = 0;

        foreach (var fruit in apple)
        {
            if(IsInHouse(fruit, s, t, a, true))
            {
                applesCount++;
            }
        }

        foreach (var fruit in orange)
        {
            if (IsInHouse(fruit, s, t, b, false))
            {
                orangeCount++;
            }
        }

        return new int[] { applesCount, orangeCount };
    }

    private static bool IsInHouse(int n, int s, int t, int tree, bool isApple)
    {
        if(isApple)
        {
            if (tree + n >= s && tree + n <= t)
            {
                return true;
            }
        }
        else
        {
            if (tree + n >= s && tree + n <= t)
            {
                return true;
            }
        }

        return false;
    }

    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
        int[] result = appleAndOrange(s, t, a, b, apple, orange);
        Console.WriteLine(String.Join("\n", result));


    }
}
