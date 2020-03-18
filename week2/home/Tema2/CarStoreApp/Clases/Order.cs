
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

		// IPerson IOrder.Person { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		// IVehicle IOrder.Vehicle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
