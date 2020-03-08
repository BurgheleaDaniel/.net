using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1r
{
	class Ex6
	{
		static public int Run(string text)
		{
			if (text.Length == 0)
			{
				return 0;
			}
			string[] words = text.Split(' ');

			if (words.Length == 0)
			{
				return 0;
			}

			return words[words.Length - 1].Length;
		}
	}
}
