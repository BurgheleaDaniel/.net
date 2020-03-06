using System;
using System.Collections;
using System.Text;

namespace Tema1
{
	public class Class1
	{
		// Main Method 
		static public void Main(String[] args)
		{

			string noDuplicates = RemoveDuplicates("ala bala portocala");
			Console.WriteLine(noDuplicates);
		}

		// Write a function to remove duplicate characters from String.
		static public string RemoveDuplicates(string text)
		{
			var sb = new StringBuilder("", text.Length);

			foreach (var item in text)
			{
				if (!sb.ToString().Contains(item.ToString()))
				{
					sb.Append(new char[] { item });
				}
			}

			return sb.ToString();
		}


	}
}
