using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class MyList<T>
	{
		private int index;
		private int count;
		private T[] data;

		public MyList()
		{
			Initialize();
		}

		private void Initialize()
		{
			count = 0;
			index = 2;
			data = new T[index];
		}

		public void Add(T item)
		{
			CheckAndAllocateArrayMemory();

			if (data.Length > count && data[count] == null)
			{
				data[count] = item;
				count++;
			}
		}

		public void Clear()
		{
			Initialize();
		}

		public void RemoveAt(int i)
		{
			for (int a = i; a < data.Length - 1; a++)
			{
				data[a] = data[a + 1];
			}

			count--;
		}

		public T[] GetList()
		{
			return data;
		}

		private void CheckAndAllocateArrayMemory()
		{
			if (count >= data.Length)
			{
				index = index * 2;
				Array.Resize(ref data, index);
			}
		}
	}
}
