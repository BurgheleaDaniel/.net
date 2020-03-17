using System;

namespace HotelApp
{
	class HotelApp
	{
		static void Main(string[] args)
		{
			HotelManager hotelManager = new HotelManager();

			Hotel hotel1 = new Hotel() { Name = "Hotel no. 1", City = 10 };
			Hotel hotel2 = new Hotel() { Name = "Hotel no. 2", City = 11 };
			Hotel hotel3 = new Hotel() { Name = "Hotel no. 3", City = 12 };

			Rate rate1 = new Rate() { Amount = 99.99m, Currency = 25 };
			Rate rate2 = new Rate() { Amount = 59.99m, Currency = 25 };
			Rate rate3 = new Rate() { Amount = 120.99m, Currency = 25 };
			Rate rate4 = new Rate() { Amount = 499.99m, Currency = 25 };

			Room room1 = new Room() { Name = "Room no. 1", Rate = rate1, Adults = 2, Children = 1 };
			Room room2 = new Room() { Name = "Room no. 2", Rate = rate2, Adults = 4, Children = 0 };
			Room room3 = new Room() { Name = "Room no. 3", Rate = rate3, Adults = 4, Children = 2 };
			Room room4 = new Room() { Name = "Room no. 4", Rate = rate4, Adults = 2, Children = 2 };

			hotel1.AddRoom(room1).AddRoom(room2).AddRoom(room3).AddRoom(room4);
			hotel2.AddRoom(room1).AddRoom(room2).AddRoom(room3).AddRoom(room4);
			hotel3.AddRoom(room1).AddRoom(room2).AddRoom(room3).AddRoom(room4);

			hotelManager.AddHotel(hotel1);
			hotelManager.AddHotel(hotel2);
			hotelManager.AddHotel(hotel3);

			int noOfRooms = 3;
			int noOfDays = 5;

			foreach (Hotel hotel in hotelManager.GetAllHotels())
			{
				int index = 0;
				hotel.Print();
				foreach (Room item in hotel.GetAllRooms())
				{
					item.Print();

					decimal priceForNoOfRooms = hotel.GetPriceForNumberOfRooms(index++, noOfRooms);
					decimal priceForNoOfDays = item.GetPriceForDays(noOfDays);
					Console.WriteLine($"Price for {noOfRooms} rooms: {priceForNoOfRooms}");
					Console.WriteLine($"Price for {noOfDays} days: {priceForNoOfDays}");

				}
			}

			hotelManager.DeleteHotel(0);

			decimal maxAmount = 108;

			foreach (Hotel hotel in hotelManager.GetAllHotels())
			{
				int index = 0;
				hotel.Print();
				foreach (Room item in hotel.GetAllRooms(maxAmount))
				{
					item.Print();

					decimal priceForNoOfRooms = hotel.GetPriceForNumberOfRooms(index++, noOfRooms);
					decimal priceForNoOfDays = item.GetPriceForDays(noOfDays);
					Console.WriteLine($"Price for {noOfRooms} rooms: {priceForNoOfRooms}");
					Console.WriteLine($"Price for {noOfDays} days: {priceForNoOfDays}");

				}
			}

		}
	}
}
