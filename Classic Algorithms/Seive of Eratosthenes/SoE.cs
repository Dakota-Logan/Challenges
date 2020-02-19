using System.Collections.Generic;
using System.Linq;

//Note Finish this!

namespace Classic_Algorithms.Seive_of_Eratosthenes
{
	public class Seive
	{
		private List<int> _primes = new List<int>();

		private List<int> _values = Enumerable.Range(2, 300).ToList();
		private List<int> _endRes = Enumerable.Range(2, 300).ToList();

		public void program()
		{
		}

		private void ByNum(List<int> nums)
		{
			for (int i = 0; i < nums.Count; i++)
			{
				for (int j = 0; j < nums.Count; j+=nums[i])
				{

				}
			}
		}
	}
}