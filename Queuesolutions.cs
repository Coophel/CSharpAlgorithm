using System;
using System.Collections.Generic;

namespace Test3
{
	public class Queuesolutions
	{
		public int[] solution(int[] pro, int[] speed)
		{
			Queue<int> complete = new Queue<int>();
			Queue<int> answer = new Queue<int>();

			for (int i = 0; i < pro.Length; i++)
			{
				int days = 0;
				while (pro[i] < 100)
				{
					pro[i] += speed[i];
					days++;
				}
				complete.Enqueue(days);
			}
			Console.WriteLine("===In Queue===");
			foreach (var a in complete)
				Console.Write(a + " ");
Console.WriteLine();
			int day = 0;
			int temp = complete.Peek();

			foreach(int x in complete)
			{
				if (x <= temp)
				{
					day++;
				}
				else
				{
					answer.Enqueue(day);
					day = 1;
					temp = x;
				}
			}
			answer.Enqueue(day);

			return answer.ToArray();
		}
	}
}