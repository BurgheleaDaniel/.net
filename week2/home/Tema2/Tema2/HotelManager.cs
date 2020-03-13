using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
	class HotelManager
	{
		private List<Hotel> hotels = new List<Hotel>();

		public HotelManager AddHotel(Hotel hotel)
		{
			this.hotels.Add(hotel);
			return this;
		}

		public HotelManager DeleteHotel(int index)
		{
			this.hotels.RemoveAt(index);
			return this;
		}

		public List<Hotel> GetAllHotels()
		{
			return this.hotels;
		}
	}
}
