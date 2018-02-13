using System;
using System.Collections.Generic;
class Solution
{

    static string super_reduced_string(string s)
    {
        Queue<char> stack = new Queue<char>();
        foreach (var item in s)
        {
            if(stack.Count > 0 && stack.Dequeue() != item)
            stack.Enqueue(item);
        }

        //var last = stack.Pop();

        //while(true)
        //{
        //    if(last == 'a')
        //    {
        //        break;
        //    }

        //    if(stack.Count == 0)
        //    {
        //        break;
        //    }

        //    char current = stack.Peek();

        //    if(current == last)
        //    {
        //        stack.Pop();
        //    }

        //    last = current;
        //}

        return string.Empty;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
