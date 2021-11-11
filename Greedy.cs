using System;
using System.Linq;

namespace Test3
{
	public class Greedy
	{
		public int greedy(int n, int[] lost, int[] reserve)
		{
			int answer = n;

			Array.Sort(lost);
			Array.Sort(reserve);

			for (int i = 0; i < lost.Length; i++)
			{
				if (lost[i] == 0)
					continue ;
				for (int j = 0; j < reserve.Length; j++)
				{
					if (lost[i] == reserve[j])
					{
						lost[i] = reserve[j] = 0;
					}
				}
			}


			for (int i = 0; i < lost.Length; i++)
			{
				if (lost[i] == 0)
					continue ;
				for (int j = 0; j < reserve.Length; j++)
				{
					if (lost[i] + 1 == reserve[j] && reserve[j] != 0)
					{
						lost[i] = reserve[j] = 0;
						break ;
					}
					else if (lost[i] - 1 == reserve[j] && reserve[j] != 0)
					{
						lost[i] = reserve[j] = 0;
						break ;
					}
				}
			}

			lost = lost.Where(val => val != 0).ToArray();
			answer -= lost.Length;
			return answer;
		}
	}
}

// 10 [5,4,3,2,1] [3,1,2,5,4] > 10
// 5 [2, 3, 4] [1, 2, 3] = 4 