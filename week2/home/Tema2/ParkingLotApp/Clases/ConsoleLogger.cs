using System;
using ParkingLotApp.Interfaces;

namespace ParkingLotApp.Clases
{
	class ConsoleLogger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
