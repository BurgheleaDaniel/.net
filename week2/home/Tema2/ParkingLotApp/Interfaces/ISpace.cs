using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Interfaces
{
	interface ISpace
	{
		string Name
		{
			get;
			set;
		}

		Byte Status
		{
			get;
			set;
		}
	}
}
