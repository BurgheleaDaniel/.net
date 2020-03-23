using System;

namespace BitArray64
{
	class Program
	{
		static void Main(string[] args)
		{
			BitArray64 bit = new BitArray64(1024);

			for (int i = 0; i < 64; i++)
			{
				Console.Write(bit[i]);
			}

			
		}
	}
}
