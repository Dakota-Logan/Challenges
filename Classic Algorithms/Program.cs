using System;
using Classic_Algorithms.Closest_Pair;
using Classic_Algorithms.Collatz_Conjecture;
using Classic_Algorithms.Seive_of_Eratosthenes;

namespace Classic_Algorithms
{
	class Program
	{
		public static bool running = true;
		static Collatz _collatz = new Collatz();
		static ClosestPair _pair = new ClosestPair();
		static Seive _soe = new Seive();

		static void Main(string[] args)
		{
			while (running)
			{
				Console.WriteLine("What program would you like to run? (Type Q to quit)");
				Console.WriteLine("The available programs are as follows: ");
				Console.WriteLine("Collatz Conjecture");
				Console.WriteLine("Closest Pair");
				Console.WriteLine("Seive of Eratosthenes (soe)");
				Console.WriteLine(Environment.NewLine);
				switch (Console.ReadLine().ToLower())
				{
					case "collatz conjecture":
					case "collatz":
						_collatz.Program();
						break;
					case "closest pair":
						_pair.program();
						break;
					case "seive of eratosthenes":
					case "seiveoferatosthenes":
					case "soe":
						_soe.program();
						break;
					case "q":
						running = false;
						break;
					default:
						Console.Clear();
						Console.WriteLine("Bad input!");
						break;
				}
			}
		}
	}
}