﻿using System;
using System.Collections.Generic;
using System.Linq;
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

		public decimal GetPriceForNumberOfRooms(int roomIndex, int numberOfRooms)
		{
			return this.rooms[roomIndex].Rate.Amount * numberOfRooms;
		}

		public List<Room> GetAllRooms()
		{
			return this.rooms;
		}

		internal List<Room> GetAllRooms(decimal maxAmount)
		{
			return this.rooms.FindAll(r => r.Rate.Amount < maxAmount);
		}
		internal void Print()
		{
			Console.WriteLine($"\nHotel details:\t{this.Name} ({this.City})");
		}

	}
}
