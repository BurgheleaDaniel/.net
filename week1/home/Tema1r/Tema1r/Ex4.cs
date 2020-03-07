using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1r
{
	class Ex4
	{
		static public void Run()
		{
			LinkedList<string> cars = new LinkedList<string>();

			cars.AddLast("Opel");
			cars.AddLast("MB");
			cars.AddLast("Audi");
			cars.AddLast("Dacia");
			cars.AddLast("Renault");
			cars.AddLast("VW");

			foreach (string car in cars)
			{
				Console.WriteLine(car + " ");
			}

			reverseList(cars.First);

			Console.WriteLine("Reversed list:");

			foreach (string car in cars)
			{
				Console.WriteLine(car + " ");
			}

		}

		static public void reverseList(LinkedListNode<string> car)
		{
			if (car.Next != null)
			{
				reverseList(car.Next);
			}
			LinkedList<string> tempList = car.List;
			LinkedListNode<string> tempNode = car;

			tempList.Remove(car);
			tempList.AddLast(tempNode);
		}
	}
}
