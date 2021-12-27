using System;
using System.Collections.Generic;

namespace Test3
{
	public class Search
	{
		public void swapValues<T>(T[] nums, int pos1, int pos2)
		{
			if (pos1 != pos2)
			{
				T temp = nums[pos1];
				nums[pos1] = nums[pos2];
				nums[pos2] = temp;
			}
		}
		// public IEnumerable<T[]> permutations<T>(T[] nums, int index = 0)
		// {
		// 	if (index + 1 == nums.Length)
		// 		yield return nums;
		// 	else
		// 	{
		// 		foreach (var v in permutations(nums, index + 1))
		// 			yield return v;

		// 		for (var i = index + 1; i <nums.Length; i++)
		// 		{
		// 			swapValues(nums, index, i);
		// 			foreach (var v in permutations(nums, index + 1))
		// 				yield return v;
		// 			swapValues(nums, index, i);
		// 		}
		// 	}
		// }
		public bool checkPrime(int number)
		{
			for (int i = 2; i <= number / 2; i++)
			{
				if (number % i != 0)
					return false;
			}
			return true;
		}

		public int solution(string numbers)
		{
			List<int> num = new List<int>();
			int[] temp;
			int answer = 0;

			foreach (var n in numbers)
			{
				num.Add(n - '0');
			}
			temp = num.ToArray();
			// var t = permutations(temp, 0);

			// foreach (var a in t)
			// {
			// 	foreach (var b in a)
			// 	{
			// 		Console.Write(b);
			// 	}
			// 	Console.WriteLine();
			// }
			return answer;
		}
	}
}