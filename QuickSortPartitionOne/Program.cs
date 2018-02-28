using System;

class Solution
{

	static int[] quickSort(int[] arr)
	{
		Array.Sort(arr);

		return arr;
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
		int[] result = quickSort(arr);
		Console.WriteLine(String.Join(" ", result));


	}
}
