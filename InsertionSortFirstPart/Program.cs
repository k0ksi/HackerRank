using System;

class Solution
{

	static void insertionSort1(int n, int[] arr)
	{
		if(arr.Length == 1)
		{
			Console.WriteLine(string.Join(" ", arr));
			return;
		}

		var lastNum = arr[arr.Length - 1];

		var last = 1;
		var beforeLast = 2;

		for (int i = arr.Length - 1; i >= 0; i--)
		{
			if(i == 0)
			{
				arr[i] = lastNum;
				Console.WriteLine(string.Join(" ", arr));
				break;
			}

			if(arr[i - 1] >= lastNum)
			{
				arr[arr.Length - last] = arr[arr.Length - beforeLast];
				last++;
				beforeLast++;
				Console.WriteLine(string.Join(" ", arr));
			}
			else
			{
				arr[i] = lastNum;
				Console.WriteLine(string.Join(" ", arr));
				break;
			}
		}		
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
		insertionSort1(n, arr);
	}
}
