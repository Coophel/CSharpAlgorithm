using System;
using System.Collections.Generic;
using System.Linq;

namespace BackJ
{
	public class B2693 : ISolution
	{
		public void solution()
		{
			int count = int.Parse(Console.ReadLine());
			List<List<int>> token = new List<List<int>>();
			
			// temporary List of numbers;
			List<int> nums = new List<int>();

			// take all of numbers by List;
			for(int i =0 ; i < count; i++)
			{
				var temp = Console.ReadLine().Split(' ');
				foreach (string x in temp)
				{
					nums.Add(int.Parse(x));
				}
				token.Add(nums.ToList());
				nums.Clear();
			}

			// sort then check 3rd number;
			foreach(var numbers in token)
			{
				numbers.Sort();
				// Console.WriteLine(numbers[7]);
			}
		}
	}
}