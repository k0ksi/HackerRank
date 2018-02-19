using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

	static string isValid(string s)
	{
		Dictionary<char, int> charOccurences = new Dictionary<char, int>();

		foreach (var ch in s)
		{
			if(charOccurences.ContainsKey(ch) == false)
			{
				charOccurences.Add(ch, 1);
			}
			else
			{
				charOccurences[ch]++;
			}
		}

		bool checkIfAllAreEqual = CheckIfAllAreEqual(charOccurences);

		HashSet<int> st = new HashSet<int>();
		foreach (var freq in charOccurences.Values)
		{
			st.Add(freq);
		}

		if(st.Count > 2)
		{
			return "NO";
		}
		else if(st.Count == 1)
		{
			return "YES";
		}
		else
		{
			int f1 = 0;
			int f2 = 0;
			int f1Count = 0;
			int f2Count = 0;
			int i = 0;

			foreach (var n in st)
			{
				if (i == 0) f1 = n;
				else f2 = n;
				i++;
			}

			foreach (var freq in charOccurences.Values)
			{
				if (freq == f1) f1Count++;
				if (freq == f2) f2Count++;
			}

			if ((f1 == 1 && f1Count == 1) || (f2 == 1 && f2Count == 1))
				return "YES";
			else if ((Math.Abs(f1 - f2) == 1) && (f1Count == 1 || f2Count == 1))
				return "YES";
			else
				return "NO";
		}

		//if (!checkIfAllAreEqual)
		//{
		//	foreach (var item in charOccurences)
		//	{
		//		var newDictionary = charOccurences.ToDictionary(entry => entry.Key,
		//														entry => entry.Value);
		//		var key = item.Key;
		//		var val = item.Value;
		//		if (key == 'k')
		//		{

		//		}
		//		newDictionary[item.Key]--;
		//		checkIfAllAreEqual = CheckIfAllAreEqual(newDictionary);

		//		if(checkIfAllAreEqual)
		//		{
		//			break;
		//		}
		//		//if(val == 1)
		//		//{
		//		//	newDictionary.Remove(key);
		//		//	checkIfAllAreEqual = CheckIfAllAreEqual(newDictionary);
		//		//}
		//	}
		//}

		return checkIfAllAreEqual ? "YES" : "NO";
	}

	static bool CheckIfAllAreEqual(Dictionary<char, int> charOccurences)
	{
		var values = charOccurences.Values.ToList();
		var first = values[0];

		return values.Skip(1).All(x => x == first);
	}

	static void Main(String[] args)
	{
		string s = Console.ReadLine();
		string result = isValid(s);
		Console.WriteLine(result);
	}
}
