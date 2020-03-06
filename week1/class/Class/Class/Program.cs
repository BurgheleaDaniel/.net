using System;
using System.Text;

namespace Class
{
	class Program
	{
		static void Main(string[] args)
		{
			//TakeLettersAndRevert(args);
			//MakeOperation(args);
			//CheckChar(args);
			//CategorisePerson(args);
			//CheckTriangle(args);
			//CheckTriangle(args);
			//SumOnlyEven(args);
		}

		private static void SumOnlyEven(string[] args)
		{
			Console.WriteLine("Input number of terms : ");
			int max = Convert.ToInt32(Console.ReadLine());
			double sum = 0;
			double evenNumber = 2;

			for (int i = 0; i < max; i++)
			{
				sum += evenNumber;
				evenNumber += 2;
			}

			Console.WriteLine("The Sum of even Natural Number upto 5 terms : " + sum);
		}

		private static void CheckTriangle(string[] args)
		{
			Console.WriteLine("Enter first angle:");
			int angle1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second angle:");
			int angle2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third angle:");
			int angle3 = Convert.ToInt32(Console.ReadLine());

			if (angle1 == angle2 && angle2 == angle3)
			{
				Console.WriteLine("This is an Equilateral triangle.");
			}
			else if (angle1 == angle2 || angle2 == angle3 || angle1 == angle3)
			{
				Console.WriteLine("This is an isosceles triangle.");

			}
			else
			{
				Console.WriteLine("This is an Scalene triangle.");
			}
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

		static void CheckChar(string[] args)
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

		static void CategorisePerson(string[] args)
		{
			Console.WriteLine("Enter height:");
			int height = Convert.ToInt32(Console.ReadLine());

			switch (height)
			{
				case int n when (n >= 200):
					Console.WriteLine($"I am the tallest person: {n}");
					break;

				case int n when (n < 200 && n >= 150):
					Console.WriteLine($"I am normal: {n}");
					break;

				case int n when (n < 150):
					Console.WriteLine($"I am dwarf: {n}");
					break;
			}
		}
	}
}
