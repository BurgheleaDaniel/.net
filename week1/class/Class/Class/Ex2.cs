using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
	class Ex2
	{
		public static void Run(string[] args)
		{
			Console.WriteLine("Enter number:");
			int op1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter operation:");
			string operation = Console.ReadLine();
			Console.WriteLine("Enter number:");
			int op2 = Convert.ToInt32(Console.ReadLine());

			switch (operation)
			{
				case "+":
					Console.WriteLine("op1 + op2 = " + (op1 + op2));
					break;
				case "-":
					Console.WriteLine("op1 + op2 = " + (op1 - op2));
					break;
				case "*":
					Console.WriteLine("op1 + op2 = " + (op1 * op2));
					break;
				case "/":
					Console.WriteLine("op1 + op2 = " + (op1 / op2));
					break;
				default:
					Console.WriteLine("Invalid operator");
					break;
			}
		}
	}
}
