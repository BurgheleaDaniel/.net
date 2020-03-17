using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
	class Room
	{
		private string name;

		private Rate rate;

		private byte adults;

		private byte children;

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

		public Rate Rate
		{
			get
			{
				return this.rate;
			}

			set
			{
				if (value.Amount <= 0 )
				{
					throw new ArgumentException("Invalid Rate!");
				}
				this.rate = value;
			}
		}

		public byte Adults
		{
			get
			{
				return this.adults;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Invalid number of adults!");
				}
				this.adults = value;
			}
		}

		public byte Children
		{
			get
			{
				return this.children;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Invalid number of children!");
				}
				this.children = value;
			}
		}

		public void Print()
		{
			Console.WriteLine($"Room Details:\t{this.Name}: price for ({this.Adults} adults & {this.Children} children)");
			this.rate.Print();
		}

		public decimal GetPriceForDays(int numberOfDays)
		{
			return this.rate.Amount * numberOfDays;
		}
	}
}
