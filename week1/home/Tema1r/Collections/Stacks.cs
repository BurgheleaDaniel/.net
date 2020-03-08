using System;
using System.Collections.Generic;

namespace Collections
{
	internal class Stacks
	{
		internal static void Run()
		{
			//6.1
			Stack<string> films = new Stack<string>();

			//6.2
			films.Push("Star Wars 1");
			films.Push("Star Wars 2");
			films.Push("Star Wars 3");

			if (films.Count <= 0)
			{
				return;
			}

			//6.3
			do
			{
				Console.WriteLine(films.Pop());
			} while (films.Count > 0);
		}
	}
}