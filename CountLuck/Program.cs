using System;
using System.Collections.Generic;

class Solution
{

    static string countLuck(string[] matrix)
    {
        Dictionary<int, MatrixRow> forest = new Dictionary<int, MatrixRow>();

        var forestRowCount = GetForestLength(matrix);

        int currentRow = -1;
        int currentCol = -1;

        for (int i = 0; i < forestRowCount; i++)
        {
            if (!forest.ContainsKey(i))
            {
                forest[i] = new MatrixRow(i);
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                var ch = matrix[i][j];

                if (!forest[i].Cells.ContainsKey(j))
                {
                    forest[i].Cells.Add(j, new Cell());
                }

                forest[i].Cells[j].Col = i;
                forest[i].Cells[j].Row = j;
                forest[i].Cells[j].Sign = ch;

                if(ch == 'M')
                {
                    currentRow = i;
                    currentCol = j;
                }
            }
        }

        bool found = false;

        while (true)
        {
            if(found)
            {
                break;
            }

            //TODO finish if condition
            var a = MoveLeft(forest, currentRow, currentCol);
            
        }

        return "";
    }

    static (bool, int, int) MoveLeft(Dictionary<int, MatrixRow> forest, int row, int col)
    {
        bool outOfForest = row - 1 < 0 || col + 1 >= forest[0].Cells.Count;
        if (outOfForest)
        {
            return (false, -1, -1);
        }


    }

    static int GetForestLength(string[] matrix)
    {
        var forestRowCount = matrix.GetLength(0);

        return forestRowCount;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] matrix = new string[n];
            for (int matrix_i = 0; matrix_i < n; matrix_i++)
            {
                matrix[matrix_i] = Console.ReadLine();
            }
            string result = countLuck(matrix);
            Console.WriteLine(result);
        }
    }

    class MatrixRow
    {
        public MatrixRow(int id)
        {
            this.Id = id;
            this.Cells = new Dictionary<int, Cell>();
        }

        public int Id { get; set; }

        public Dictionary<int, Cell> Cells{ get; set; }
    }

    class Cell
    {
        public int Row { get; set; }

        public int Col { get; set; }

        public char Sign { get; set; }
    }
}
