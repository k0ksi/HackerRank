using System;

class Solution
{

	static string funnyString(string s)
	{
		char[] charArr = s.ToCharArray();
		Array.Reverse(charArr);
		var reversed = new string(charArr);

		var firstChar = (int)s[0];
		var reversedFirstChar = (int)reversed[0];

		var result = true;

		for (int i = 1; i < s.Length; i++)
		{
			var firstVal1 = s[i];
			var firstVal2 = s[i - 1];
			var secVal1 = reversed[i];
			var secVal2 = reversed[i - 1];

			var value1 = Math.Abs(firstVal1 - firstVal2);
			var value2 = Math.Abs(secVal1 - secVal2);

			if (value1 != value2)
			{
				result = false;
				break;
			}
		}

		var funny = "Funny";
		var notFunny = "Not Funny";
		var res = funny;

		if(!result)
		{
			res = notFunny;
		}

		return res;
	}

	static void Main(String[] args)
	{
		int q = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < q; a0++)
		{
			string s = Console.ReadLine();
			string result = funnyString(s);
			Console.WriteLine(result);
		}
	}
}
