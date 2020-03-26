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

		int IComparable<BusinessDate>.CompareTo(BusinessDate other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<BusinessDate>.Equals(BusinessDate other)
		{
			throw new NotImplementedException();
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

		string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
		{
			return this.ToString();
		}

		public override string ToString()
		{
			return $"{this.Day}-{this.Month}-{this.Year}";
		}

		public override bool Equals(Object obj)
		{
			return obj is BusinessDate && this == (BusinessDate)obj;
		}

		public static bool operator ==(BusinessDate x, BusinessDate y)
		{
			return x.Year == y.Year && x.Month == y.Month && x.Day == y.Day;
		}

		public static bool operator !=(BusinessDate x, BusinessDate y)
		{
			return x.Year != y.Year || x.Month != y.Month || x.Day != y.Day;
		}

	}
}

