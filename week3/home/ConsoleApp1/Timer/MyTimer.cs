using System;
using System.Threading;

namespace Timer
{
	class MyTimer
	{
		public delegate void MessageDelegate(string str);

		private MessageDelegate msgDel = Notify;

		private string message;

		private int seconds;

		public MyTimer(string msg, int sec)
		{
			message = msg;
			seconds = sec;
		}

		public void Run()
		{
			while (true)
			{
				msgDel(message);
				Thread.Sleep(seconds * 1000);
			}
		}

		static void Notify(string str)
		{
			Console.WriteLine($"Notification received for: {str}");
		}
	}
}
