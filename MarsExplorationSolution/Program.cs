using System;
using System.Text;

class Solution
{

	static int marsExploration(string s)
	{
		int sosMessagesCount = s.Length / 3;
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < sosMessagesCount; i++)
		{
			sb.Append("SOS");
		}

		var compare = sb.ToString();

		int result = 0;

		for (int i = 0; i < s.Length; i++)
		{
			var originalChar = s[i];
			var charToCompare = compare[i];

			if(originalChar != charToCompare)
			{
				result++;
			}
		}

		return result;
	}

	static void Main(String[] args)
	{
		string s = Console.ReadLine();
		int result = marsExploration(s);
		Console.WriteLine(result);
	}
}
