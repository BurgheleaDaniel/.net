using System;
using System.Collections.Generic;
using System.Text;

namespace BitArray64
{
	class BitArray64
	{
		public ulong number;

		public BitArray64(ulong val)
		{
			if (val < ulong.MinValue || val > ulong.MaxValue)
			{
				throw new ArgumentException(String.Format("Value {0} is invalid!", val));
			}
			this.number = val;
		}

		// Indexer declaration
		public ulong this[int index]
		{
			get
			{
				if (index >= 0 && index <= 63)
				{
					return (this.number >> index) & 1ul;
				}
				else
				{
					throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
				}
			}
			set
			{
				if (index < 0 || index > 63)
				{
					throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
				}
				if (value < 0 || value > 1)
				{
					throw new ArgumentException(String.Format("Value {0} is invalid!", value));
				}

				// Clear the bit at position index
				this.number &= ~(1ul << index);

				// Set the bit at position index to value
				this.number |= 1ul << index;
			}
		}

	}
}
