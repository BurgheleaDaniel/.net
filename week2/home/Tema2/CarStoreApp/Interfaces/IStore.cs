
using System.Collections.Generic;

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

		void AddVehicle(IVehicle vehicle);

		List<IVehicle> GetAllVehicles();

		void PlaceOrder(IOrder order);

		List<IOrder> GetAllOrders();

		void CancelOrder(IOrder order);
	}
}
