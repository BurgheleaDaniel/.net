using System;
using System.Collections.Generic;
using System.Text;
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

		List<Vehicle> vehicles = new List<Vehicle>();
		List<Order> orders = new List<Order>();

		public void AddVehicle(Vehicle vehicle)
		{
			vehicles.Add(vehicle);
			logger.Log($"Vehicle was added");
			logger.Log($"Details: {vehicle.Make} {vehicle.Model} {vehicle.Year} {vehicle.Price} ");
		}

		public List<Vehicle> GetAllVehicles()
		{
			return vehicles;
		}

		public void PlaceOrder(Order order)
		{
			orders.Add(order);
			logger.Log($"Order was added");
			logger.Log($"Details: {order.Person.Name} {order.Vehicle.Make} {order.Vehicle.Model} {order.Vehicle.Year} {order.Vehicle.Price} {order.DeliveryTime}");
		}

		public List<Order> GetAllOrders()
		{
			return orders;
		}

		public void CancelOrder(Order order)
		{
			logger.Log($"Order was canceled");
			logger.Log($"Details: {order.Person.Name} {order.Vehicle.Make} {order.Vehicle.Model} {order.Vehicle.Year} {order.Vehicle.Price} {order.DeliveryTime}");

			orders.Remove(order);
		}
	}
}
