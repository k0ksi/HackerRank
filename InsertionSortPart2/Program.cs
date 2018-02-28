using System;

class Solution
{

	static void insertionSort2(int n, int[] inputarray)
	{
		for (int i = 0; i < inputarray.Length - 1; i++)
		{
			int j = i + 1;

			while (j > 0)
			{
				if (inputarray[j - 1] > inputarray[j])
				{
					int temp = inputarray[j - 1];
					inputarray[j - 1] = inputarray[j];
					inputarray[j] = temp;

				}
				j--;
			}

			Console.WriteLine(string.Join(" ", inputarray));
		}
		//return inputarray;

		//var lastSortedIndex = 1;

		//for (int i = 1; i < arr.Length; i++)
		//{
		//	var currentElement = arr[i];

		//	for (int j = lastSortedIndex; j >= 0; j--)
		//	{
		//		if(arr[j] <= currentElement)
		//		{

		//		}
		//		else
		//		{
		//			var current = arr[j];
		//			arr[j] = currentElement;
		//			if(j + 1 <= arr.Length - 1)
		//			{
		//				arr[j + 1] = current;
		//			}

		//			lastSortedIndex = j;
		//			break;
		//		}
		//	}
		//}
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
		insertionSort2(n, arr);
	}
}
