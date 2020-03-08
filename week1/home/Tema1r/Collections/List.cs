using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
	class List
	{
		static public void Run()
		{
			//3.1
			List<string> list = new List<string>();

			//3.2
			list.Insert(0, "Chewbacca");
			Console.WriteLine(list[0]);

			//3.3
			List<string> characters = new List<string>() {
				"Luke Skywalker",
				"Han Solo",
				"Chewbacca"
			};
			characters.Remove("Luke Skywalker");

			//3.4
			List<string> chars = new List<string>() {
				"Luke Skywalker",
				"Han Solo",
				"Chewbacca"
			};
			chars.RemoveAt(2);

			//3.5
			List<string> characters2 = new List<string>()
			{
				"Luke Skywalker",
				"Han Solo",
				"Chewbacca"
			};
			foreach (string item in characters2)
			{
				Console.WriteLine(item);
			}
		}
	}
}
