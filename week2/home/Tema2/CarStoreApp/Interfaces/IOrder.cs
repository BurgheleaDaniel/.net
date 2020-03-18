
using System;

namespace CarStoreApp.Interfaces
{
	interface IOrder
	{
		IPerson Person
		{
			get;
			set;
		}

		IVehicle Vehicle
		{
			get;
			set;
		}

		string Status
		{
			get;
			set;
		}

		DateTime DeliveryTime
		{
			get;
			set;
		}
	}
}
