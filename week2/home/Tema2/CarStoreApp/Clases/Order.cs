
using System;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class Order : IOrder
	{
		private string status;

		public IPerson Person { get; set; }

		public IVehicle Vehicle { get; set; }

		public string Status
		{
			get
			{
				return this.status;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid status!");
				}
				this.status = value;
			}
		}

		public DateTime DeliveryTime { get; set; }

	}
}
