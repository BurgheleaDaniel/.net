using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class MyList<T> : IEnumerable<T>
	{
		private int capacity;
		private int count;
		private T[] data;

		public MyList()
		{
			Initialize();
		}

		private void Initialize()
		{
			count = 0;
			capacity = 2;
			data = new T[capacity];
		}

		public void Add(T item)
		{
			CheckAndAllocateArrayMemory();

			if (data[count] == null)
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
				capacity = capacity * 2;
				Array.Resize(ref data, capacity);
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			foreach (T item in data)
			{
				yield return item;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
