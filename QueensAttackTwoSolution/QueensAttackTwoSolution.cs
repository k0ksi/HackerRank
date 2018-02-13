using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttackII
{
    /*
     * January 30, 2017
     * problem statement:
     * https://www.hackerrank.com/contests/world-codesprint-9/challenges/queens-attack-2
     *            
     */
    public class Directions
    {
        // start from left, clockwise, left and up, up, right and up, right, 
        //            right and down, down, left and down
        public static int[] directions_row = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };
        public static int[] directions_col = new int[] { -1, -1, 0, 1, 1, 1, 0, -1 };

        public int rows { get; set; }

        public Tuple<int, int> queen { set; get; }

        public Directions(int row, int col, int size)
        {
            queen = new Tuple<int, int>(row, col);

            rows = size;
        }

        public int CalculateTotal(Tuple<int, int>[] obstacles)
        {
            // put all obstacles in a hashset
            var obstacleHashed = new HashSet<Tuple<int, int>>();
            foreach (Tuple<int, int> obstacle in obstacles)
            {
                obstacleHashed.Add(obstacle);
            }

            // go over each direction
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                int rowIncrement = directions_row[i];
                int colIncrement = directions_col[i];

                int runnerRow = queen.Item1 + rowIncrement;
                int runnerCol = queen.Item2 + colIncrement;

                while (runnerRow >= 0 && runnerRow < rows &&
                       runnerCol >= 0 && runnerCol < rows &&
                       !obstacleHashed.Contains(new Tuple<int, int>(runnerRow, runnerCol)))
                {
                    runnerRow += rowIncrement;
                    runnerCol += colIncrement;

                    count++;
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProcessInput();
        }

        public static void ProcessInput()
        {
            var data = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int rows = data[0];
            int countObstacles = data[1];

            var queen = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var obstacles = new Tuple<int, int>[countObstacles];

            for (int i = 0; i < countObstacles; i++)
            {
                var obstacle = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                obstacles[i] = new Tuple<int, int>(obstacle[0] - 1, obstacle[1] - 1);
            }

            var directions = new Directions(queen[0] - 1, queen[1] - 1, rows);
            Console.WriteLine(directions.CalculateTotal(obstacles));
        }
    }
}