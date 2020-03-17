using System;
using CarStoreApp.Clases;

namespace CarStoreApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Alex intended to buy a Ford Focus 2015 model.
			Person alex = new Person() { Name = "Alex" };

			//FileLogger logger = new FileLogger() { Path = "log.txt" };
			ConsoleLogger logger = new ConsoleLogger();

			Producer fordProducer = new Producer() { Name = "Ford Craiova" };

			//He walked to the FordStore in Bucuresti and agreed to buy one for *15000Euro.
			Store fordStore = new Store(logger) { Name = "FordStore", Location = "Bucuresti" };
			Vehicle vehicle1 = new Vehicle() { Make = "Ford", Model = "Focus", Year = 2015, Price = 15000, Producer = fordProducer };
			fordStore.AddVehicle(vehicle1);

			//They informed him it will take 4 weeks for delivery.
			Order order1 = new Order() { Person = alex, Vehicle = vehicle1, Status = "new", DeliveryTime = DateTime.Today.AddDays(28) };
			fordStore.PlaceOrder(order1);

			//He then decided to visit another store SkodaStore and agreed to buy one * for 14000Euro and 3 weeks delivery.
			Store skodaStore = new Store(logger) { Name = "SkodaStore" };
			Vehicle vehicle2 = new Vehicle() { Make = "Ford", Model = "Focus", Year = 2015, Price = 14000, Producer = fordProducer };
			skodaStore.AddVehicle(vehicle2);

			Order order2 = new Order() { Person = alex, Vehicle = vehicle2, Status = "new", DeliveryTime = DateTime.Today.AddDays(21) };
			skodaStore.PlaceOrder(order2);

			//He then canceled his original order from the FordStore.
			fordStore.CancelOrder(order1);

			//After 3 weeks, he received the model.
			order2.Status = "delivered";
		}
	}
}
