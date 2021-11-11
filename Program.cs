using System;
using System.Diagnostics;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
			Stopwatch m1 = new Stopwatch();
            // Solutions s = new Solutions();
			// int[] num= new int[] {1,2,7,6,4};
			// Console.WriteLine("Answer: " + s.solutions(num));

			// Greedy g = new Greedy();
			// int[] lost = new int[] {2,3,4};
			// int[] rev = new int[] {1,2,3};
			// Console.WriteLine("Answer: " + g.greedy(5,lost,rev));

			// Stringbuilder sb = new Stringbuilder();
			// Stringbuilder sa = new Stringbuilder();
			// string str = "tRy HELLO world";
			// m1.Start();
			// var r1 = sa.solutions(str);
			// m1.Stop();
			// Console.WriteLine(r1 + "\ttime : " + m1.ElapsedTicks + "ms");
			// m1.Reset();
			// m1.Start();
			// var r2 = sb.solution(str);
			// m1.Stop();
			// Console.WriteLine(r2 + "\ttime : " + m1.ElapsedTicks + "ms");

// [20, 99, 93, 30, 55, 10], [5, 10, 1, 1, 30, 5], [3, 3]
// [93, 30, 55]	[1, 30, 5]	[2, 1]
			// Queuesolutions q = new Queuesolutions();
			// int[] pro = new int[] {93, 30, 55};
			// int[] spd = new int[] {1, 30, 5};
			// m1.Start();
			// int[] answer = q.solution(pro, spd);
			// m1.Stop();
			// foreach(var x in answer)
			// 	Console.Write(x + "\t");
			// Console.WriteLine();
			// Console.WriteLine("time : " + m1.ElapsedTicks + "ms");

			Search c = new Search();
        }
    }
}

