using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> list = new MyList<string>();
			list.Add("aaa");
			list.Add("bbb");
			list.Add("ccc");
			list.Add("ddd");
			list.Add("eee");

			list.RemoveAt(2);
		}
	}
}
