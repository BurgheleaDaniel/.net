
using System;
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
