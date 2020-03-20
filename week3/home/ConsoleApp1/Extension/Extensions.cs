using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
	public static class Extensions
	{
		public static T Sum<T>(this IEnumerable<T> list)
		{
			T suma = (dynamic)0;
			foreach (var item in list)
			{
				suma += (dynamic)item;
			}
			return suma;
		}

		public static T Product<T>(this IEnumerable<T> list)
		{
			T product = (dynamic)1;
			foreach (var item in list)
			{
				product *= (dynamic)item;
			}
			return product;
		}

		public static T Min<T>(this IEnumerable<T> list)
		{
			T min = (dynamic)(new List<T>(list)[0]);
			foreach (var item in list)
			{
				if (min > (dynamic)item)
				{
					min = (dynamic)item;
				}
			}
			return min;
		}

		public static T Max<T>(this IEnumerable<T> list)
		{
			T max = (dynamic)(new List<T>(list)[0]);
			foreach (var item in list)
			{
				if (max < (dynamic)item)
				{
					max = (dynamic)item;
				}
			}
			return max;
		}

		public static T Average<T>(this IEnumerable<T> list)
		{
			return (dynamic)list.Sum() / new List<T>(list).Count;
		}

	}
}
