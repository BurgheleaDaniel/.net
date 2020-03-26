using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDate
{
	class Clock : IClock
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
