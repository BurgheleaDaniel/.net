using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BusinessDate
{
	class Program
	{
		private static void Main(string[] args)
		{
			var ci = new CultureInfo("fr-FR");

			SystemClock systemClock = new SystemClock();

			Console.WriteLine(systemClock.Now.ToString());
			Console.WriteLine(systemClock.UtcNow.ToString());
			Console.WriteLine(systemClock.Today.ToString());

			var date = new BusinessDate(2014, 3, 28);


			var date2 = BusinessDate.ParseFromIso8601String("2015-06-10");
			Console.WriteLine(date < date2);

		}


	}


}
