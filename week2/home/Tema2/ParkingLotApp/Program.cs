using System;
using System.Collections.Generic;
using ParkingLotApp.Clases;
using ParkingLotApp.Interfaces;

namespace ParkingLotApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			ConsoleLogger logger = new ConsoleLogger();

			ParkingLot parkingLot = new ParkingLot(logger) { Name = "Palas Parking Lot" };

			int maxLevels = 5;
			int maxSpaces = 100;
			for (int i = 0; i < maxLevels; i++)
			{
				Level tmpLevel = new Level() { Name = $"Level {i}" };
				for (int j = 0; j < maxSpaces; j++)
				{
					Space tmpSpace = new Space() { Name = $"Space {i}-{j}", Status = 1 };
					tmpLevel.AddSpace(tmpSpace);
				}
				parkingLot.AddLevel(tmpLevel);
			}

			Car car1 = new Car() { Name = "Dacia", LicencePlate = "IS-10-OOO" };

			if (parkingLot.GetAllOpenSpaces() > 0)
			{
				List<ILevel> levels = parkingLot.GetAllLevels();

				while (true)
				{
					// choose a random level and parking space
					int rndLevel = rnd.Next(maxLevels);
					if (levels[rndLevel] != null)
					{
						int rndSpace = rnd.Next(maxSpaces);
						List<ISpace> spaces = levels[rndLevel].GetAllSpaces();
						if (spaces[rndSpace] != null && spaces[rndSpace].Status == 1)
						{
							spaces[rndSpace].Status = 0;

							logger.Log($"---------");
							logger.Log($"Level: {levels[rndLevel].Name}");
							logger.Log($"Update space: {spaces[rndSpace].Name}");
							logger.Log($"New status: {spaces[rndSpace].Status}");
							logger.Log($"Car Licence Plate: {car1.LicencePlate}");
							break;
						}
					}
				}
			}


		}

	}
}
