using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
	class Hotel
	{
		private string name;

		private uint city;

		private List<Room> rooms = new List<Room>();

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

		public uint City
		{
			get
			{
				return this.city;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid city!");
				}

				this.city = value;
			}
		}

		public Hotel AddRoom(Room room)
		{
			this.rooms.Add(room);
			return this;
		}

		public List<Room> GetAllRooms()
		{
			return this.rooms;
		}

		public decimal GetPriceForNumberOfRooms(int roomIndex, int numberOfRooms)
		{
			return this.rooms[roomIndex].Rate.Amount * numberOfRooms;
		}

		internal void Print()
		{
			Console.WriteLine($"\nHotel details:\t{this.Name} ({this.City})");
		}
	}
}
