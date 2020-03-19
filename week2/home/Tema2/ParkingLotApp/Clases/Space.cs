using System;
using System.Collections.Generic;
using System.Text;
using ParkingLotApp.Interfaces;

namespace ParkingLotApp.Clases
{
	class Space : ISpace
	{
		private string name;

		private byte status;

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

		public byte Status
		{
			get
			{
				return this.status;
			}

			set
			{
				if (value != 0 && value != 1)
				{
					throw new ArgumentException("Invalid status!");
				}
				this.status = value;
			}
		}
	}
}
