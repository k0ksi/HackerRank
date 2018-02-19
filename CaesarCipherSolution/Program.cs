using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{
	//11
	//middle-Outz => okffng-Qwvb
	//2
	static string caesarCipher(string s, int k)
	{
		int aNum = 96;
		int zNum = 122;

		int ANum = 64;
		int ZNum = 90;

		StringBuilder sb = new StringBuilder();

		string pattern = @"[a-zA-Z]";

		foreach (var ch in s)
		{
			if (Regex.IsMatch(ch.ToString(), pattern))
			{
				if(char.IsLower(ch))
				{
					sb.Append(GetLetter(ch, aNum, zNum, k));
				}
				else
				{
					sb.Append(GetLetter(ch, ANum, ZNum, k));
				}

			} 
			else
			{
				sb.Append(ch);
			}
		}

		return sb.ToString();
	}

	private static char GetLetter(char ch, int aNum, int zNum, int k)
	{
		int charNum = (int)ch;
		int newPos = charNum + k;

		while (true)
		{
			if(newPos >= aNum && newPos <= zNum)
			{
				break;
			}

			if (newPos > zNum)
			{
				int diff = newPos - zNum;
				newPos = aNum + diff;

				if (ch == zNum)
				{
					//newPos = aNum + 1;
				}
				else
				{
					
				}
			}
		}		

		return (char)newPos;
	}	

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string s = Console.ReadLine();
		int k = Convert.ToInt32(Console.ReadLine());
		string result = caesarCipher(s, k);
		Console.WriteLine(result);
	}
}
