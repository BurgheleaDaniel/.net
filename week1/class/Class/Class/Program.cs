using System;
using System.Text;

namespace Class
{
	class Program
	{
		static void Main(string[] args)
		{
			//TakeLettersAndRevert(args);
			MakeOperation(args);
		}

		static void TakeLettersAndRevert(string[] args)
		{
			Console.WriteLine("Enter letter:");
			string v1 = Console.ReadLine();
			Console.WriteLine("Enter letter:");
			string v2 = Console.ReadLine();
			Console.WriteLine("Enter letter:");
			string v3 = Console.ReadLine();

			Console.WriteLine("-------");

			StringBuilder sb = new StringBuilder();
			sb.Append(v3);
			sb.Append(v2);
			sb.Append(v1);

			Console.WriteLine(sb.ToString());
		}

		static void MakeOperation(string[] args)
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
