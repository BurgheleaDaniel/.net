using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Interfaces
{
	interface ILevel
	{
		string Name
		{
			get;
			set;
		}

		void AddSpace(ISpace space);

		List<ISpace> GetAllSpaces();
	}
}
