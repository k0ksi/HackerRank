using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Solution
{
	class Solution
	{
		static void Main(string[] args)
		{
			string pangram = "pangram";
			string notpangram = "not pangram";
			string pattern = "[a-zA-Z]";

			string input = Console.ReadLine();

			string text = input.ToLower();

			HashSet<int> userChars = new HashSet<int>();

			foreach (var ch in text)
			{
				if (userChars.Count == 26)
				{
					break;
				}

				if (Regex.IsMatch(ch.ToString(), pattern))
				{
					userChars.Add(ch);
				}
			}

			Console.WriteLine(userChars.Count == 26 ? pangram : notpangram);
		}
	}
}
