using System;

class Solution
{
    // TODO Not yet implemented
    static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
    {
        bool[,] matrix = new bool[n, n];

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                if(n == r_q - 1)
                {
                    matrix[i, j] = true;
                }

                if(j == c_q - 1)
                {
                    matrix[i, j] = true;
                }
            }
        }

        matrix[r_q - 1, c_q - 1] = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

        return 0;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] tokens_r_q = Console.ReadLine().Split(' ');
        int r_q = Convert.ToInt32(tokens_r_q[0]);
        int c_q = Convert.ToInt32(tokens_r_q[1]);
        int[][] obstacles = new int[k][];
        for (int obstacles_i = 0; obstacles_i < k; obstacles_i++)
        {
            string[] obstacles_temp = Console.ReadLine().Split(' ');
            obstacles[obstacles_i] = Array.ConvertAll(obstacles_temp, Int32.Parse);
        }
        int result = queensAttack(n, k, r_q, c_q, obstacles);
        Console.WriteLine(result);
    }
}
