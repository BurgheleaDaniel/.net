using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
	class Ex5
	{
		public static void Run(string[] args)
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
	}
}
