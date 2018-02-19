using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

	static void separateNumbers(string s)
	{
		if(s[0] == '0')
		{
			Console.WriteLine("NO");
			return;
		}

		var res = false;

		for (int length = 1; length * 2 <= s.Length; length++)
		{
			long firstNum = long.Parse(s.Substring(0, length));

			StringBuilder sb = new StringBuilder();
			long num = firstNum;

			while (sb.Length < s.Length)
			{
				sb.Append(num);
				num++;
			}

			if(sb.ToString().Equals(s))
			{
				res = true;
				Console.WriteLine("YES " + firstNum);
			}
		}

		if(!res)
		{
			Console.WriteLine("NO");
		}
	}

	static void Main(String[] args)
	{
		int q = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < q; a0++)
		{
			string s = Console.ReadLine();
			separateNumbers(s);
		}
	}
}
