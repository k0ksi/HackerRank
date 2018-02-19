using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static string hackerrankInString(string s)
	{
		string yes = "YES";
		string no = "NO";

		string initial = "hackerrank";

		int index = 0;
		char current = initial[index];

		foreach (var ch in s)
		{
			if (index == 10)
			{
				break;
			}

			current = initial[index];

			if (ch == current)
			{
				index++;
			}
		}

		string result = index == 10 ? yes : no;

		return result;
	}

	private static bool CheckIfStringIsHackerRank(string s)
	{
		bool result = false;

		if(String.Equals(s, "hackerrank", StringComparison.OrdinalIgnoreCase))
		{
			result = true;
		}

		return result;
	}

	static void Main(String[] args)
	{
		int q = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < q; a0++)
		{
			string s = Console.ReadLine();
			string result = hackerrankInString(s);
			Console.WriteLine(result);
		}
	}
}
