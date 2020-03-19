using System;
using System.Collections.Generic;
using System.Text;
using ParkingLotApp.Interfaces;

namespace ParkingLotApp.Clases
{
	class Car : ICar
	{
		private string name;

		private string licencePlate;

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

		public string LicencePlate
		{
			get
			{
				return this.licencePlate;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid Licence Plate!");
				}
				this.licencePlate = value;
			}
		}
	}
}
