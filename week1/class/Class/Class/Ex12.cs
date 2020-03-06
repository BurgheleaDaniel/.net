using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
	class Ex12
	{
		public static void Run(string[] args)
		{
			Console.WriteLine("Input the size of array: ");
			int index = Convert.ToInt32(Console.ReadLine());

			int[] values = new int[index];

			for (int i = 0; i < index; i++)
			{
				Console.WriteLine("Enter the element: ");
				values[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Input the value to be inserted : ");
			int element = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input the Position, where the value to be inserted : ");
			int position = Convert.ToInt32(Console.ReadLine()) - 1;

			int[] newArr = new int[index + 1];

			int count = 0;
			foreach (int i in values)
			{
				if (newArr.Length >= count)
				{
					if (count == position)
					{
						newArr[position] = element;
						count++;
					}

					newArr[count] = i;
					count++;
				}
			}

			Console.WriteLine("The current list of the array :");
			Console.WriteLine(string.Join(",", values));

			Console.WriteLine("After Insert the element the new list is :");
			Console.WriteLine(string.Join(",", newArr));

		}
	}
}
