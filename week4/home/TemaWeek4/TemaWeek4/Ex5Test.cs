using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemaWeek4
{
	[TestClass]
	public class Ex5Test
	{
		[TestMethod]
		public void TestShoulPassTrueSmoothSentence()
		{
			Assert.AreEqual(Ex5.IsSmooth("Marta appreciated deep perpendicular right trapezoids"), true);
			Assert.AreEqual(Ex5.IsSmooth("She eats super righteously"), true);
		}

		[TestMethod]
		public void TestShoulPassFalseSmoothSentence()
		{
			Assert.AreEqual(Ex5.IsSmooth("Someone is outside the doorway"), false);
		}
	}
}
