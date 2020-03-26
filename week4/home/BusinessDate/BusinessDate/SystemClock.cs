using System;

namespace BusinessDate
{
	class SystemClock : IClock
	{
		public DateTime Now
		{
			get
			{
				return DateTime.Now;
			}
		}

		public DateTime UtcNow
		{
			get
			{
				return DateTime.UtcNow;
			}
		}

		public BusinessDate Today
		{
			get
			{
				return BusinessDate.Today;
			}
		}
	}
}
