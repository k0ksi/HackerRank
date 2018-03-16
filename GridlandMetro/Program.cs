using System;

class Solution
{
    static int gridlandMetro(int n, int m, int k, int[][] track)
    {
        long counter = n * m;
        
        for (int i = 0; i < track.GetLength(0); i++)
        {
            var r = track[i][0] - 1;
            var c1 = track[i][1] - 1;
            var c2 = track[i][2];

            for (int j = c1; j < c2; j++)
            {
                counter--;
            }
        }

        return (int)counter;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        int k = Convert.ToInt32(tokens_n[2]);
        int[][] track = new int[k][];
        for (int track_i = 0; track_i < k; track_i++)
        {
            string[] track_temp = Console.ReadLine().Split(' ');
            track[track_i] = Array.ConvertAll(track_temp, Int32.Parse);
        }
        int result = gridlandMetro(n, m, k, track);
        Console.WriteLine(result);
    }
}
