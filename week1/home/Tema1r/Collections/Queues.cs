using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
	class Queues
	{
		static public void Run()
		{
			//5.1
			Queue<int> primes = new Queue<int>();

			//5.2
			primes.Enqueue(2);
			primes.Enqueue(3);
			primes.Enqueue(5);
			primes.Enqueue(7);
			primes.Enqueue(11);

			//5.3
			int total = 0;
			while (primes.Count > 0)
			{
				int item = primes.Dequeue();
				total += item;
			}
			Console.WriteLine(total);

		}
	}
}
