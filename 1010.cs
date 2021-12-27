using System;

namespace BackJ
{
	public class my
	{
		public void Bridge()
		{
			int count = int.Parse(Console.ReadLine());
			int[,] token = new int[count,2];
			for(int i = 0; i < count; i++)
			{
				string[] temp = Console.ReadLine().Split(' ');
				token[i, 0] = int.Parse(temp[0]);
				token[i, 1] = int.Parse(temp[1]);
			}


			for(int a = 0; a < count; a++)
			{
				long answer = 1;
				for (int b = 0; b < token[a,0]; b++)
				{
					answer *= token[a,1] - b;
					answer /= 1 + b;
				}
				Console.WriteLine(answer);
			}
		}
	}
}