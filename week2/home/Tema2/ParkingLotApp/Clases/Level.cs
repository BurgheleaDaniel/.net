using System;
using System.Collections.Generic;
using System.Text;
using ParkingLotApp.Interfaces;

namespace ParkingLotApp.Clases
{
	class Level : ILevel
	{
		private string name;

		List<ISpace> spaces = new List<ISpace>();

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

		public void AddSpace(ISpace space)
		{
			spaces.Add(space);
		}

		public List<ISpace> GetAllSpaces()
		{
			return spaces;
		}
	}
}
