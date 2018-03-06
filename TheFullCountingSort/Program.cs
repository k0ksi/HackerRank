using System;
using System.Collections.Generic;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        string[] texts = new string[n];

        Dictionary<int, List<string>> textOccurences = new Dictionary<int, List<string>>();

        for (int a0 = 0; a0 < n; a0++)
        {
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            string s = tokens_x[1];

            numbers[a0] = x;

            if (a0 >= n / 2)
                texts[a0] = s;
            else
                texts[a0] = "-";

            s = texts[a0];

            if (textOccurences.ContainsKey(x))
            {
                textOccurences[x].Add(s);
            }
            else
            {
                var initList = new List<string>();
                initList.Add(s);
                textOccurences.Add(x, initList);
            }
        }

        int[] occurences = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            var item = numbers[i];
            occurences[item]++;
        }

        List<int> result = new List<int>();        

        for (int i = 0; i < occurences.Length; i++)
        {
            int count = occurences[i];

            for (int j = 0; j < count; j++)
            {
                result.Add(i);
            }
        }

        var current = int.MinValue;

        List<string> finalResult = new List<string>();

        foreach (var item in result)
        {
            if(item != current)
            {
                finalResult.AddRange(textOccurences[item]);
            }

            current = item;
        }

        Console.WriteLine(string.Join(" ", finalResult));
    }
}
