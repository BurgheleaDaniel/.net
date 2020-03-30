﻿//nuget package
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessDate
{
	[TestClass]
	public class BusinessDateTest
	{
		[TestMethod]
		public void ConstructedAsSpecified()
		{
			var date = new BusinessDate(2014, 3, 28);
			date.Day.Should().Be(28);
			date.Month.Should().Be(3);
			date.Year.Should().Be(2014);
		}

		[TestMethod]
		public void BusinessDateIsEqualToItself()
		{
			var date = new BusinessDate(2015, 10, 06);
			Equality(date, date, true);
		}

		[TestMethod]
		public void CanBeParsedFromIso8601DateString()
		{
			BusinessDate.ParseFromIso8601String("2015-06-10").Should().Be(new BusinessDate(2015, 6, 10));
		}

		[TestMethod]
		public static void Equality(BusinessDate left, BusinessDate right, bool areEqual)
		{
			left.Equals(right).Should().Be(areEqual);
			(left == right).Should().Be(areEqual);
			(left != right).Should().Be(!areEqual);
			(left.GetHashCode() == right.GetHashCode()).Should().Be(areEqual);
		}
	}
}
