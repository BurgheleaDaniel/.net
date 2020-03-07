using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1r
{
	class Ex1
	{
		static public void Run(string text)
		{
			var sb = new StringBuilder("", text.Length);

			foreach (var item in text)
			{
				if (!sb.ToString().Contains(item.ToString()))
				{
					sb.Append(new char[] { item });
				}
			}

			Console.WriteLine(sb.ToString());
		}
	}
}
