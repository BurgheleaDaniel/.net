using System;
using System.Collections.Generic;

namespace Collections
{
	internal class LinkedLists
	{
		internal static void Run()
		{
			//7.1
			LinkedList<string> movies = new LinkedList<string>();

			//7.2
			movies.AddFirst("Avatar");

			LinkedListNode<string> titanic = new LinkedListNode<string>("Titanic");
			movies.AddLast(titanic);
			movies.AddAfter(titanic, "Star Wars: The Force Awakens");

			//7.3
			LinkedList<string> droids = new LinkedList<string>();

			droids.AddLast("C-3PO");
			droids.AddLast("AZI-3");
			droids.AddLast("R2-D2");
			droids.AddLast("IG-88");
			droids.AddLast("2-1B");

			droids.Remove("C-3PO");

			movies.Remove(movies.Find("R2-D2"));

			movies.RemoveLast();
		}
	}
}