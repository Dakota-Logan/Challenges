using System;
using System.Collections.Generic;
using System.Threading;

namespace Classic_Algorithms.Closest_Pair
{
	public class ClosestPair
	{
		private int[][] _pairs = new int[][]
		{
			new[] {1, 1},
			new[] {1, 7},
			new[] {3, 9},
			new[] {5, 5},
			new[] {3, 2},
			new[] {8, 6},
			new []{9, 2},
			new []{3, 4},
			new []{7, 5},
			new []{1, 5}
		};

		private float minDist = 22f;

		private int iterations;

		private bool _subRunning = true;


		public void program()
		{
			Console.Clear();

			while (_subRunning)
			{
				Console.WriteLine("Which method would you like to use?");
				Console.WriteLine("The available methods: ");
				Console.WriteLine("Brute Force (b/f)");
				switch (Console.ReadLine().ToLower())
				{
					case "brute force":
					case "bruteforce":
					case "brute":
					case "b/f":
						BruteForce(_pairs);
						break;
					case "q":
						_subRunning = false;
						break;
					default:
						Console.Clear();
						Console.WriteLine("Bad Input");
						Thread.Sleep(250);
						break;
				}
			}
		}

		private void BruteForce(in int[][] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int[] ipair = arr[i];
				for (int j = 0; j < arr.Length; j++)
				{
					int[] jpair = arr[j];
					if(i==j) continue;
					// if calcdist current interation < mindist
					float dist = CalcDist(ipair, jpair);
					if (dist < minDist) minDist = dist;
					iterations++;
				}
			}

			Console.Clear();
			Thread.Sleep(250);
			Console.WriteLine("Brute Force Complete");
			Thread.Sleep(250);
			Console.WriteLine("The minimum distance is: " + minDist);
			Console.WriteLine("This Calulation was completed in " + iterations + " iterations.");
		}

		private float CalcDist(in int[] first, in int[] second)
		{
			int x = first[0] + second[0];
			int y = first[1] + second[1];
			int d = (x * x) + (y * y);
			return d / (x + y);
		}
	}
}