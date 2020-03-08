using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
	class Arrays
	{
		static public void Run()
		{
			//2.1
			string[] array = new string[0];

			//2.2
			string[] names = new string[1];
			names[0] = "Han Solo";
			Console.WriteLine(names[0]);

			//2.3
			int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}
		}
	}
}
