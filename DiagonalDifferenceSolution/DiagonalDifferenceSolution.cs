using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int diagonalDifference(int[][] a)
    {
        int firstDiagonalSum = 0;
        int secondDiagonalSum = 0;
        int firstDiagonalIndex = 0;
        int lastDiagonalIndex = a[0].Length - 1;

        for (int i = 0; i < a.Length; i++)
        {
            firstDiagonalSum += a[i][firstDiagonalIndex];
            secondDiagonalSum += a[i][lastDiagonalIndex];

            firstDiagonalIndex++;
            lastDiagonalIndex--;
        }

        return Math.Abs(firstDiagonalSum - secondDiagonalSum);
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }
        int result = diagonalDifference(a);
        Console.WriteLine(result);
    }
}
