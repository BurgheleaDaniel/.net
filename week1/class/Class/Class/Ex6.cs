using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
	class Ex6
	{
		public static void Run(string[] args)
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
	}
}
