using System;
using System.Collections.Generic;
using System.Text;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class ConsoleLogger : Ilogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
