using System;
using System.Collections.Generic;
using System.Linq;

namespace Test3
{
	public class Biggest {
		public string solution(int[] numbers) {
			// 정렬에 사용할 리스트 튜플<기존 숫자 , 정렬에 사용할 숫자>
			List<Tuple<int,int>>temp = new List<Tuple<int,int>>();
			// 정답 리턴용
			string answer = "";
			// 기존 숫자 임시 저장소
			int origin = 0;

			// 배열의 내용을 받는 루프문
			for (int i = 0; i < numbers.Length; i++) {
				origin = numbers[i];

				// 배열 숫자를 (자신의 숫자로 반복하여) 4자리로 전부 만들어주는 루프문
				while (numbers[i] <= 1000) {
					if (numbers[i] == 0)
						break;
					numbers[i] = (int)(numbers[i] * Math.Pow(10, numbers[i].ToString().Length) + numbers[i]) % 10000;
				}

				// 정렬할 리스트에 저장
				temp.Add(new Tuple<int,int>(origin, numbers[i]));
			}

			// 리스트 정렬 : 4자리 숫자로 정렬
			temp = temp.OrderByDescending(t=>t.Item2).ToList();

			// 원래 숫자 문자열로 합치기
			for (int i = 0; i < temp.Count; i++)
			{
				if (answer == "0")
					break ;
				answer += temp[i].Item1.ToString();
			}

			return answer;
		}
	}
}