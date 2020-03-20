using System;
using System.Collections.Generic;

namespace Extension
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			list.Add(1);
			list.Add(2);
			list.Add(3);
			list.Add(4);
			list.Add(5);

			Console.WriteLine(list.Sum());
			Console.WriteLine(list.Product());
			Console.WriteLine(list.Min());
			Console.WriteLine(list.Max());
			Console.WriteLine(list.Average());
		}
	}
}
