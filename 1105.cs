using System;

namespace BackJ
{
	class B1105 : ISolution
	{
		// get number of eight function;
		public int geteight(int num)
		{
			int count = 0;

			while (num > 10)
			{
				if (num % 10 == 8)
					count++;
				num /= 10;
			}
			if (num == 8)
				count++;
			return count;
		}
		public void solution()
		{
			string[] input = Console.ReadLine().Split(' ');
			// init number of eight by Max;
			int num = 9999999;
			
			// Check the number of eight in our range;
			for (int i = int.Parse(input[0]); i <= int.Parse(input[1]); i++)
			{
				int temp = geteight(i);
				if (num > temp)
					num = temp;
				else if (temp == 0)
					break ;
			}

			Console.WriteLine(num);
		}
	}
}