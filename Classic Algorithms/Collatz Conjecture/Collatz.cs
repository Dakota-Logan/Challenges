using System;
using System.Threading;

namespace Classic_Algorithms.Collatz_Conjecture
{
	public class Collatz
	{
		private int n;
		private int startingNum;
		private int steps;

		public void Program()
		{
			Console.Clear();
			Console.Write("Please enter a number:");
			Console.Write("");
			n = Convert.ToInt32(Console.ReadLine());
			startingNum = n;
			Console.WriteLine("You entered: "+n);
			Thread.Sleep(500);
			// n = n>1
			// if n == even | n = n/2
			// if n == odd | n = n*3+1
			while (n != 1)
			{
				if (n % 2 == 0)
					even();
				else
					odd();
			}

			Console.WriteLine($"n started at {startingNum} cycles and took {steps} to get to 1.");
			Thread.Sleep(2500);
		}

		private void even()
		{
			n = n / 2;
			steps++;
			Console.WriteLine(n);
			Thread.Sleep(35);
		}

		private void odd()
		{
			n = (3 * n) + 1;
			steps++;
			Console.WriteLine(n);
			Thread.Sleep(75);
		}
	}
}