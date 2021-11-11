using System;
using System.Text;

namespace Test3
{
	public class Stringbuilder
	{
		// another solution
		public string solution(string s)
		{
			string answer = "";
			int num = 0;

			for(int i = 0; i < s.Length; i++)
			{
				answer += num % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
				num = s[i] == ' '? 0 : num + 1;
			}

			return answer;
    	}
		// my solution
		public string solutions(string s)
		{
			StringBuilder sb = new StringBuilder(s);
			int temp = 0;

			for (int i = 0; i < sb.Length; i++)
			{
				if (sb[i] == ' ')
				{
					temp = 0;
					continue ;
				}
				else if (temp % 2 == 0)
				{
					sb[i] = char.ToUpper(sb[i]);
					temp++;
				}
				else
				{
					sb[i] = char.ToLower(sb[i]);
					temp++;
				}
        	}

			return sb.ToString();
		}
	}
}