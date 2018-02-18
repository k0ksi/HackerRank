using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    // beabeefeab -> babab
    static int twoCharaters(string s)
    {
        int len = s.Length;
        int longestSolution = 0;

        for (int i = 0; i < 26; i++)
        {
            for (int j = i + 1; j < 26; j++)
            {
                char ch1 = (char)((int)'a' + i);
                char ch2 = (char)((int)'a' + j);

                int currentChar = -1;
                int countChar = 0;

                for (int z = 0; z < len; z++)
                {
                    if(s[z] == ch1)
                    {
                        if(currentChar == 1)
                        {
                            currentChar = -1;
                            break;
                        }

                        currentChar = 1;
                        countChar++;
                    }
                    else if (s[z] == ch2)
                    {
                        if (currentChar == 2)
                        {
                            currentChar = -1;
                            break;
                        }
                        currentChar = 2;
                        countChar++;
                    }
                }

                if (currentChar != -1 &&
                    countChar > 1 &&
                    countChar > longestSolution)
                {
                    longestSolution = countChar;
                }
            }
        }

        return longestSolution;
    }

    private static HashSet<char> CountDistinctChars(string s)
    {
        HashSet<char> chars = new HashSet<char>();

        foreach (var ch in s)
        {
            chars.Add(ch);
        }

        return chars;
    }

    static void Main(String[] args)
    {
        int l = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = twoCharaters(s);
        Console.WriteLine(result);
    }
}
