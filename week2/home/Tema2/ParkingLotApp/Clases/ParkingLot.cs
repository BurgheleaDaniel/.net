using System;
using System.Collections.Generic;
using System.Text;
using ParkingLotApp.Interfaces;

namespace ParkingLotApp.Clases
{
	class ParkingLot : IParkingLot
	{
		private string name;

		List<ILevel> levels = new List<ILevel>();

		private ILogger logger;

		public ParkingLot(ILogger logger)
		{
			this.logger = logger;
		}

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

		public void AddLevel(ILevel level)
		{
			levels.Add(level);
			logger.Log($"Level was added");
			logger.Log($"Details: {level.Name}");
		}

		public List<ILevel> GetAllLevels()
		{
			return levels;
		}

		public int GetAllOpenSpaces()
		{
			int openSpaces = 0;
			foreach (ILevel level in levels)
			{
				List<ISpace> Result = new List<ISpace>(level.GetAllSpaces().FindAll(spaceIsOpen));
				openSpaces += Result.Count;
			}
			return openSpaces;
		}

		private static bool spaceIsOpen(ISpace i)
		{
			return (i.Status == 1);
		}
	}
}
