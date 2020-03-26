using System;

namespace BusinessDate
{
	public interface IClock
	{
		DateTime Now { get; }

		DateTime UtcNow { get; }

		BusinessDate Today { get; }
	}
}
