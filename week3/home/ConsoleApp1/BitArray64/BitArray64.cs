using System;
using System.Collections.Generic;
using System.Text;

namespace BitArray64
{
	class BitArray64
	{
		private ulong value;

		public BitArray64(ulong val)
		{
			if (val < ulong.MinValue || val > ulong.MaxValue)
			{
				throw new ArgumentException(String.Format("Value {0} is invalid!", val));
			}
			value = val;
		}

		// Indexer declaration
		public ulong this[int index]
		{
			get
			{
				if (index >= 0 && index <= 63)
				{
					// Check the bit at position index
					if ((value & (ulong)(1 << index)) == 0)
					{
						return 0;
					}
					else
					{
						return 1;
					}
				}
				else
				{
					throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
				}
			}
			set
			{
				if (index < 0 || index > 31)
				{
					throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
				}
				if (value < 0 || value > 1)
				{
					throw new ArgumentException(String.Format("Value {0} is invalid!", value));
				}

				// Clear the bit at position index
				value &= ~((ulong)(1 << index));

				// Set the bit at position index to value
				value |= (ulong)(value << index);
			}
		}

	}
}
