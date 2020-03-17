using System;
using System.Collections.Generic;
using System.Text;
using CarStoreApp.Clases;

namespace CarStoreApp.Interfaces
{
	interface IVehicle
	{
		string Make
		{
			get;
			set;
		}

		string Model
		{
			get;
			set;
		}

		int Year
		{
			get;
			set;
		}

		decimal Price
		{
			get;
			set;
		}

		Producer Producer
		{
			get;
			set;
		}
	}
}
