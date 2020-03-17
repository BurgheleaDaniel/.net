using System;
using System.Collections.Generic;
using System.Text;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class Person : IPerson
	{
		private string name;

		public string Name
		{
			get
			{
				return this.name;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid name!");
				}
				this.name = value;
			}
		}
	}
}
