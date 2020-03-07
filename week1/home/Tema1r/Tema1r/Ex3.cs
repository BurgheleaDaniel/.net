using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1r
{
	class Ex3
	{
		static public void Run(string text)
		{
			if (text.Length == 0)
			{
				return;
			}

			Dictionary<char, int> dict = new Dictionary<char, int>();

			foreach (var item in text)
			{
				dict[item] = dict.ContainsKey(item) ? dict[item] + 1 : 1;
			}

			foreach (KeyValuePair<char, int> kvp in dict)
			{
				Console.WriteLine("{0} has a frequency of {1}", kvp.Key, kvp.Value);
			}

		}
	}
}
