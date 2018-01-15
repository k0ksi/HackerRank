using System;
class Solution
{

    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        int firstPos = x1;
        int firstJump = v1;
        int secondPos = x2;
        int secondJump = v2;

        int firstKangaroo = firstPos;
        int secondKangaroo = secondPos;
        string result = "NO";
        
        while (true)
        {
            if (firstKangaroo > secondKangaroo && firstJump >= secondJump)
            {
                break;
            }

            if(firstKangaroo < secondKangaroo && firstJump <= secondJump)
            {
                break;
            }

            if (firstKangaroo == secondKangaroo)
            {
                result = "YES";
                break;
            }
            firstKangaroo += firstJump;
            secondKangaroo += secondJump;
        }

        return result;
    }

    static void Main(String[] args)
    {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
