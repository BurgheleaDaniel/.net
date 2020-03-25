using System;

namespace BitArray64
{
	class Program
	{
		static void Main(string[] args)
		{
			BitArray64 bit = new BitArray64(7);

			Console.WriteLine(bit.number);

			bit[0] = 0;
			Console.WriteLine(bit.number);

			bit[20] = 1;
			Console.WriteLine(bit.number);

			for (int i = 0; i < 64; i++)
			{
				Console.Write(bit[i]);
			}

			
		}
	}
}
