

namespace Exceptions
{
	[System.Serializable]
	public class InvalidRangeException<T> : System.Exception
	{
		private static readonly string DefaultMessage = $"Input is out or accepted range";

		public T RangeStart { get; set; }
		public T RangeEnd { get; set; }

		public InvalidRangeException() : base(DefaultMessage) { }
		public InvalidRangeException(string message) : base(message) { }
		public InvalidRangeException(string message, System.Exception innerException)
		: base(message, innerException) { }

		public InvalidRangeException(T rangeStart, T rangeEnd) : base(DefaultMessage)
		{
			RangeStart = rangeStart;
			RangeEnd = rangeEnd;
		}

		public InvalidRangeException(T rangeStart, T rangeEnd, System.Exception innerException)
		: base(DefaultMessage, innerException)
		{
			RangeStart = rangeStart;
			RangeEnd = rangeEnd;
		}

		protected InvalidRangeException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
