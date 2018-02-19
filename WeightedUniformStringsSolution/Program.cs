using System;
using System.Collections.Generic;

class Solution
{

	static void Main(String[] args)
	{
		int subtractVal = 96;

		string s = Console.ReadLine();

		HashSet<int> sums = new HashSet<int>();

		var character = s[0];
		var currentCount = 1;
		sums.Add(character - subtractVal);

		for (int i = 1; i < s.Length; i++)
		{
			var ch = s[i];

			if(ch == character)
			{
				currentCount++;
				sums.Add(currentCount * (character - subtractVal));
			}
			else
			{
				currentCount = 1;
				character = ch;
				sums.Add(character - subtractVal);
			}
		}

		int n = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < n; a0++)
		{
			int x = Convert.ToInt32(Console.ReadLine());

			if(sums.Contains(x))
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
