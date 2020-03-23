using System;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			// ex 1
			ParseNumberBetween(1, 100);

			// ex 2
			ParseDateBetween(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
		}

		static int ParseNumberBetween(int start, int end)
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

		private static void ParseDateBetween(DateTime dateTimeStart, DateTime dateTimeEnd)
		{
			InvalidRangeException<DateTime> dateTimeRange = new InvalidRangeException<DateTime>() { RangeStart = dateTimeStart, RangeEnd = dateTimeEnd };

			try
			{
				Console.WriteLine($"Input a year");
				int year = ParseNumberBetween(1, 9999);

				Console.WriteLine($"Input a month");
				int month = ParseNumberBetween(1, 12);

				Console.WriteLine($"Input a day");
				int day = ParseNumberBetween(1, 31);

				DateTime date = new DateTime(year, month, day);
				if (date < dateTimeRange.RangeStart || date > dateTimeRange.RangeEnd)
				{
					throw dateTimeRange;
				}
			}
			catch (InvalidRangeException<DateTime> e)
			{
				Console.WriteLine(e.Message);
				throw;
			}
		}
	}
}
