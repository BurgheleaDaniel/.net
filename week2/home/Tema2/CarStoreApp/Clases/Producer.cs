
using System;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class Producer : IProducer
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
