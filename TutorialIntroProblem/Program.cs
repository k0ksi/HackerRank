using System;

class Solution
{

	static int introTutorial(int V, int[] arr)
	{
		var result = 0;

		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == V)
			{
				result = i;
			}
		}

		return result;
	}

	static void Main(String[] args)
	{
		int V = Convert.ToInt32(Console.ReadLine());
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
		int result = introTutorial(V, arr);
		Console.WriteLine(result);
	}
}
