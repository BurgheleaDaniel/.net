using System;

namespace Timer
{
	class Program
	{
		static void Main(string[] args)
		{
			MyTimer timer = new MyTimer("alabalaportocala", 2);
			timer.Run();
		}
	}
}
