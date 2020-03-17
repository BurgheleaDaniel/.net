using System;
using System.Collections.Generic;
using System.Text;
using CarStoreApp.Clases;

namespace CarStoreApp.Interfaces
{
	interface IOrder
	{
		Person Person
		{
			get;
			set;
		}

		Vehicle Vehicle
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
