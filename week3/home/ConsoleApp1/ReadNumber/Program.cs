using System;
using Exceptions;
using System.Linq;
using System.Collections.Generic;

namespace ReadNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int length = 9;
			int i = 0;
			List<int> numbers = new List<int> { 1 };

			do
			{
				try
				{
					int currentNumber = ReadNumber(1, 100);
					if (currentNumber > 1 && currentNumber < 100 && (numbers.Count() == 0 || currentNumber > numbers.Last()))
					{
						numbers.Add(currentNumber);
					}
					else
					{
						throw new Exception("Exception! The next inequality is not true: (1 < a1 < ... < a10 < 100)");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					throw;
				}

				i++;
			} while (i <= length);
		}

		static int ReadNumber(int start, int end)
		{
			InvalidRangeException<int> intRange = new InvalidRangeException<int>() { RangeStart = start, RangeEnd = end };
			Console.WriteLine($"Input a number between {intRange.RangeStart} - {intRange.RangeEnd}");
			int number = Int32.Parse(Console.ReadLine());

			try
			{
				if (number < intRange.RangeStart || number > intRange.RangeEnd)
				{
					throw intRange;
				}
			}
			catch (InvalidRangeException<int> e)
			{
				Console.WriteLine(e.Message);
				throw;
			}

			return number;
		}
	}
}
