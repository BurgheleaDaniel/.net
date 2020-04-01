using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaWeek4
{
	class Ex5
	{
		static public void Run()
		{
			bool smooth;
			smooth = IsSmooth("Marta appreciated deep perpendicular right trapezoids");
			Console.WriteLine(smooth);

			smooth = IsSmooth("Someone is outside the doorway");
			Console.WriteLine(smooth);

			smooth = IsSmooth("She eats super righteously");
			Console.WriteLine(smooth);
		}

		static public bool IsSmooth(string sentence)
		{
			IEnumerable<String> words = sentence.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
			int len = words.Count();

			for (int i = 0; i < len - 1; i++)
			{
				if (words.ElementAt(i).Last() != words.ElementAt(i + 1).First())
				{
					return false;
				}
			}

			return true;
		}
	}
}
