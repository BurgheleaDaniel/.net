using System;
using System.Collections.Generic;
using System.Text;
using CarStoreApp.Clases;

namespace CarStoreApp.Interfaces
{
	interface IStore
	{
		string Name
		{
			get;
			set;
		}

		string Location
		{
			get;
			set;
		}

		void AddVehicle(Vehicle vehicle);

		List<Vehicle> GetAllVehicles();

		void PlaceOrder(Order order);

		List<Order> GetAllOrders();

		void CancelOrder(Order order);
	}
}
