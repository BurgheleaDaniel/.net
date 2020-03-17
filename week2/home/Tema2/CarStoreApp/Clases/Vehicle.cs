using System;
using System.Collections.Generic;
using System.Text;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class Vehicle : IVehicle
	{
		private string make;

		private string model;

		private int year;

		private decimal price;

		public string Make
		{
			get
			{
				return this.make;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid make!");
				}
				this.make = value;
			}
		}

		public string Model
		{
			get
			{
				return this.model;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid model!");
				}
				this.model = value;
			}
		}

		public int Year
		{
			get
			{
				return this.year;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid year!");
				}
				this.year = value;
			}
		}

		public decimal Price
		{
			get
			{
				return this.price;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid price!");
				}
				this.price = value;
			}
		}

		public Producer Producer { get; set; }
	}
}
