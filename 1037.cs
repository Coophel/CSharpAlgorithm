using System;
using System.Linq;

namespace BackJ
{
	public class B1037 : ISolution
	{
		public void solution()
		{
			// read divisor count;
			int count = int.Parse(Console.ReadLine());
			
			// read divisors;
			string[] token = Console.ReadLine().Split(' ');
			int[] divisor = new int[token.Length];
			
			int index = 0;
			// get divisor by int;
			foreach (string x in token)
			{
				divisor[index] = int.Parse(x);
				index++;
			}

			// check min / max divisor;
			int min = divisor.Min();
			int max = divisor.Max();

			Console.WriteLine(min * max);
		}
	}
}