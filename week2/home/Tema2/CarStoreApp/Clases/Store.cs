
using System;
using System.Collections.Generic;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Clases
{
	class Store : IStore
	{
		private string name;

		private string location;

		private Ilogger logger;

		public Store(Ilogger logger)
		{
			this.logger = logger;
		}

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

		public string Location
		{
			get
			{
				return this.location;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid location!");
				}
				this.location = value;
			}
		}

		List<IVehicle> vehicles = new List<IVehicle>();
		List<IOrder> orders = new List<IOrder>();

		public void AddVehicle(IVehicle vehicle)
		{
			vehicles.Add(vehicle);
			logger.Log($"Vehicle was added");
			logger.Log($"Details: {vehicle.Make} {vehicle.Model} {vehicle.Year} {vehicle.Price} ");
		}

		public List<IVehicle> GetAllVehicles()
		{
			return vehicles;
		}

		public void PlaceOrder(IOrder order)
		{
			orders.Add(order);
			logger.Log($"Order was added");
			logger.Log($"Details: {order.Person.Name} {order.Vehicle.Make} {order.Vehicle.Model} {order.Vehicle.Year} {order.Vehicle.Price} {order.DeliveryTime}");
		}

		public List<IOrder> GetAllOrders()
		{
			return orders;
		}

		public void CancelOrder(IOrder order)
		{
			logger.Log($"Order was canceled");
			logger.Log($"Details: {order.Person.Name} {order.Vehicle.Make} {order.Vehicle.Model} {order.Vehicle.Year} {order.Vehicle.Price} {order.DeliveryTime}");

			orders.Remove(order);
		}
	}
}
