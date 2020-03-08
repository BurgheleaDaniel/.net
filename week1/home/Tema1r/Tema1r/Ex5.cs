using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1r
{
	class Ex5
	{
		static public void Run()
		{
			LinkedList<int> list = new LinkedList<int>();
			Dictionary<int, int> dict = new Dictionary<int, int>();

			list.AddLast(1);
			list.AddLast(2);
			list.AddLast(5);
			list.AddLast(2);
			list.AddLast(8);
			list.AddLast(5);
			list.AddLast(2);
			list.AddLast(2);
			list.AddLast(5);
			list.AddLast(5);
			list.AddLast(3);
			list.AddLast(2);
			list.AddLast(2);


			LinkedListNode<int> node = list.First;
			while (node != null)
			{
				if (!dict.ContainsKey(node.Value))
				{
					dict[node.Value] = node.Value;
					node = node.Next;
				}
				else
				{
					if (node.Next != null)
					{
						node = node.Next;
						list.Remove(node.Previous);
					}
					else
					{
						list.Remove(node);
						node = null;
					}
				}
			}

			foreach (int nod in list)
			{
				Console.WriteLine(nod + " ");
			}
		}
	}
}
