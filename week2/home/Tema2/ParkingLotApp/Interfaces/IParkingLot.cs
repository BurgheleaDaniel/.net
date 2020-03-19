using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Interfaces
{
	interface IParkingLot
	{
		string Name
		{
			get;
			set;
		}

		void AddLevel(ILevel level);

		List<ILevel> GetAllLevels();

		int GetAllOpenSpaces();
	}
}
