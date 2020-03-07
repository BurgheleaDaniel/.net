using System;
using System.Collections.Generic;
using System.Linq;

namespace Tema1r
{
	class Ex2
	{
		static public void Run(int[] values)
		{
			int n = values.Length;
			if (n == 0)
			{
				return;
			}

			Dictionary<int, int> dict = new Dictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				dict[values[i]] = dict.ContainsKey(values[i]) ? dict[values[i]] + 1 : 1;
			}

			if (dict.Values.Max() > n / 2)
			{
				var max = dict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
				Console.WriteLine("Majority Element is: {0}", max);
			}
			else
			{
				Console.WriteLine("No Majority Element");
			}
		}
	}
}
