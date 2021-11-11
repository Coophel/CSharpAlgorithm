using System;
using System.Collections.Generic;

namespace Test3
{
// 	주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다.
//	숫자들이 들어있는 배열 nums가 매개변수로 주어질 때, nums에 있는 숫자들 중 서로 다른 3개를 골라 더했을 때
//	소수가 되는 경우의 개수를 return 하도록 solution 함수를 완성해주세요.

// 	제한사항
//	 nums에 들어있는 숫자의 개수는 3개 이상 50개 이하입니다.
//	 nums의 각 원소는 1 이상 1,000 이하의 자연수이며, 중복된 숫자가 들어있지 않습니다.
	public class Solutions {
		public static List<int> primelist = new List<int>();
		List<int> numsSum = new List<int>();
		int[] selected = new int[3] {0,0,0};
		public void makeprimelist() {
			for (int i = 2; i <= 3000; i++) {
				primelist.Add(i);
			}
			for (int i = 2; i <= 1500; i++) {
				primelist.RemoveAll(delegate (int x) { return x > i && x % i == 0;});
			}
		}
		public void combination(int sum, int[] nums, int depth, int index) {
			int i;

			if ( 3 == depth) {
				for(i = 0; i < 3; i++){
					sum += selected[i];
					// Console.Write("selected[{0}]: ",i);
					// Console.Write(selected[i] + "\t");
				}
				numsSum.Add(sum);
				sum = 0;
				return ;
			}
			for (i = index; i < nums.GetLength(0); i++) {
				selected[depth] = nums[i];
				combination(sum, nums, depth + 1, i + 1);
 			}
		}
		public bool checkprime(int num) {
			if (primelist.Contains(num))
				return true;
			return false;
		}
		public int solutions (int[] nums) {
			Array.Sort(nums);
			int answer = 0;

			makeprimelist();
			combination(answer, nums, 0, 0);
			answer = 0;
			foreach (int i in numsSum) {
				if (checkprime(i))
					answer++;
			}

			return (answer);
		}
	}
}