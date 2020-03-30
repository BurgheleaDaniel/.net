using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BusinessDate
{
	public struct BusinessDate : IFormattable, IEquatable<BusinessDate>, IComparable<BusinessDate>, IXmlSerializable
	{
		public int Day { get; set; }

		public int Month { get; set; }

		public int Year { get; set; }

		public BusinessDate(int year, int month, int day)
		{
			this.Year = year;
			this.Month = month;
			this.Day = day;
		}

		public static BusinessDate Today
		{
			get
			{
				return new BusinessDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			}
		}

		internal static BusinessDate ParseFromIso8601String(string v)
		{
			string[] result = v.Split('-');
			if (result.Count() != 3)
			{
				throw new Exception("wrong input parameters for ParseFromIso8601String. Try with: '2015-06-10'");
			}

			return new BusinessDate(Int32.Parse(result[0]), Int32.Parse(result[1]), Int32.Parse(result[2]));
		}

		bool IEquatable<BusinessDate>.Equals(BusinessDate other)
		{
			return this.Equals(other);
		}

		public override bool Equals(Object obj)
		{
			return obj is BusinessDate && this == (BusinessDate)obj;
		}

		public override int GetHashCode()
		{
			return Convert.ToInt32(string.Format("{0}{1}{2}", this.Year, this.Month, this.Day));
		}

		int IComparable<BusinessDate>.CompareTo(BusinessDate other)
		{
			// If other is not a valid object reference, this instance is greater.
			if (other == null) return 1;

			if (this < other)
			{
				return 1;
			}
			else if (this > other)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}

		public static bool operator ==(BusinessDate x, BusinessDate y)
		{
			return x.Year == y.Year && x.Month == y.Month && x.Day == y.Day;
		}

		public static bool operator !=(BusinessDate x, BusinessDate y)
		{
			return x.Year != y.Year || x.Month != y.Month || x.Day != y.Day;
		}

		public static bool operator >(BusinessDate x, BusinessDate y)
		{
			return
				(x.Year.CompareTo(y.Year) == 1)
				|| (x.Year.CompareTo(y.Year) == 1 && x.Month.CompareTo(y.Month) == 1)
				|| (x.Year.CompareTo(y.Year) == 1 && x.Month.CompareTo(y.Month) == 1 && x.Day.CompareTo(y.Day) == 1);
		}

		public static bool operator <(BusinessDate x, BusinessDate y)
		{
			return
				(x.Year.CompareTo(y.Year) == -1)
				|| (x.Year.CompareTo(y.Year) == -1 && x.Month.CompareTo(y.Month) == -1)
				|| (x.Year.CompareTo(y.Year) == -1 && x.Month.CompareTo(y.Month) == -1 && x.Day.CompareTo(y.Day) == -1);
		}

		public static bool operator >=(BusinessDate x, BusinessDate y)
		{
			return
				(x.Year.CompareTo(y.Year) >= 0)
				|| (x.Year.CompareTo(y.Year) >= 0 && x.Month.CompareTo(y.Month) >= 0)
				|| (x.Year.CompareTo(y.Year) >= 0 && x.Month.CompareTo(y.Month) >= 0 && x.Day.CompareTo(y.Day) >= 0);
		}

		public static bool operator <=(BusinessDate x, BusinessDate y)
		{
			return
				(x.Year.CompareTo(y.Year) <= 0)
				|| (x.Year.CompareTo(y.Year) <= 0 && x.Month.CompareTo(y.Month) <= 0)
				|| (x.Year.CompareTo(y.Year) <= 0 && x.Month.CompareTo(y.Month) <= 0 && x.Day.CompareTo(y.Day) <= 0);
		}


		string IFormattable.ToString(string format, IFormatProvider formatProvider)
		{
			return this.ToString();
		}

		public override string ToString()
		{
			return $"{this.Day}-{this.Month}-{this.Year}";
		}


		// it's okay not to implement them 
		XmlSchema IXmlSerializable.GetSchema()
		{
			throw new NotImplementedException();
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			throw new NotImplementedException();
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			throw new NotImplementedException();
		}

	}
}

