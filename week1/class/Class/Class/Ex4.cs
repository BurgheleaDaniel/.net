using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
	class Ex4
	{
		public static void Run(string[] args)
		{
			Console.WriteLine("Enter height:");
			int height = Convert.ToInt32(Console.ReadLine());

			switch (height)
			{
				case int n when (n >= 200):
					Console.WriteLine($"I am the tallest person: {n}");
					break;

				case int n when (n < 200 && n >= 150):
					Console.WriteLine($"I am normal: {n}");
					break;

				case int n when (n < 150):
					Console.WriteLine($"I am dwarf: {n}");
					break;
			}
		}
	}
}
