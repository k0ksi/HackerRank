using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{
    static string encryption(string s)
    {
        string text = Regex.Replace(s, @"\s+", "");
        int length = text.Length;

        int sqrt = (int)Math.Ceiling(Math.Sqrt(length));
        int cols = sqrt;
        int possibleRowsNumber = 1;
        List<int> possibleRows = new List<int>();

        while(true)
        {
            if(possibleRowsNumber > cols)
            {
                break;
            }

            if(cols * possibleRowsNumber >= length)
            {
                possibleRows.Add(possibleRowsNumber);
            }

            possibleRowsNumber++;
        }

        int rows = possibleRows.Min();

        char[,] chars = new char[rows, cols];

        int currentStart = 0;
        int textCols = cols;

        for (int i = 0; i < chars.GetLength(0); i++)
        {
            if (length - currentStart < textCols)
            {
                textCols = length - currentStart;
            }

            string current = text.Substring(currentStart, textCols);

            for (int j = 0; j < textCols; j++)
            {
                chars[i, j] = current[j];
            }

            currentStart += current.Length;
        }

        var characters = RotateMatrixCounterClockwise(RotateMatrixCounterClockwise(RotateMatrixCounterClockwise(chars)));

        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < characters.GetLength(0); i++)
        {
            StringBuilder innerSb = new StringBuilder();

            for (int j = 0; j < characters.GetLength(1); j++)
            {
                if (characters[i, j] != 0)
                    innerSb.Append(characters[i, j]);
                else
                    innerSb.Append("");
            }

            char[] charsInner = innerSb.ToString().ToCharArray();

            Array.Reverse(charsInner);

            sb.Append(new string(charsInner));

            sb.Append(" ");
        }
        
        string result = sb.ToString().TrimEnd();

        return result;
    }

    static char[,] RotateMatrixCounterClockwise(char[,] oldMatrix)
    {
        char[,] newMatrix = new char[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
        int newColumn, newRow = 0;
        for (int oldColumn = oldMatrix.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
        {
            newColumn = 0;
            for (int oldRow = 0; oldRow < oldMatrix.GetLength(0); oldRow++)
            {
                newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                newColumn++;
            }
            newRow++;
        }
        return newMatrix;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = encryption(s);
        Console.WriteLine(result);
    }
}
