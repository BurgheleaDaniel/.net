using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
	class Dictionaries
	{
		static public void Run()
		{
			//4.1
			Dictionary<string, int> dict = new Dictionary<string, int>();

			//4.2
			Dictionary<string, int> people = new Dictionary<string, int>();
			people.Add("Daniel", 27);
			people["AnotherDaniel"] = 22;

			Console.WriteLine(people["Daniel"]);

			//4.3
			Dictionary<string, bool> characters = new Dictionary<string, bool>()
			{
				{ "Luke", true },
				{ "Han", false },
				{ "Chewbacca", false }
			};
			characters.Remove("Han");

			//4.4
			foreach (var item in characters)
			{
				Console.WriteLine("key: {0}, values: {1}", item.Key, item.Value);
			}

		}
	}
}
