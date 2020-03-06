using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
	class Ex3
	{
		public static void Run(string[] args)
		{
			Console.WriteLine("Enter char:");
			char op1 = Convert.ToChar(Console.ReadLine().ToLower());

			string vowel = "aeiou";
			string digits = "0123456789";

			if (vowel.ToLower().Contains(op1))
			{
				Console.WriteLine("It's a lowercase vowel");
			}
			else if (digits.ToLower().Contains(op1))
			{
				Console.WriteLine("It's a digit");
			}
			else
			{
				Console.WriteLine("It's other symbol");
			}
		}
	}
}
