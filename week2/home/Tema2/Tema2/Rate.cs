using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace HotelApp
{
	public class Rate
	{
		private decimal amount;

		private uint currency;

		public decimal Amount
		{
			get
			{
				return this.amount;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid amount!");
				}

				this.amount = value;
			}
		}

		public uint Currency
		{
			get
			{
				return this.currency;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid currency!");
				}

				this.currency = value;
			}
		}

		public void Print()
		{
			Console.WriteLine($"Total rate:\t{this.Amount} ({this.Currency})");
		}

	}
}
