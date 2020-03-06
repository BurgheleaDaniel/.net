using System;
using System.Text;

namespace Class
{
	class Ex1
	{
		public static void Run(string[] args)
		{
			Console.WriteLine("Enter letter:");
			string v1 = Console.ReadLine();
			Console.WriteLine("Enter letter:");
			string v2 = Console.ReadLine();
			Console.WriteLine("Enter letter:");
			string v3 = Console.ReadLine();

			Console.WriteLine("-------");

			StringBuilder sb = new StringBuilder();
			sb.Append(v3);
			sb.Append(v2);
			sb.Append(v1);

			Console.WriteLine(sb.ToString());
		}
	}
}
