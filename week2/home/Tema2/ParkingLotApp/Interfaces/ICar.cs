using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Interfaces
{
	interface ICar
	{
		string Name
		{
			get;
			set;
		}

		string LicencePlate
		{
			get;
			set;
		}
	}
}
