using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUppgifter_2;

namespace UnitTestProject2
{
	[TestClass]
	public class TestStrCount
	{
		[TestMethod]
		public void Test__Length_7()
		{
			string input = "1234567";
			int expected = 7;

			int result = StringUtils.StrCount(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Empty_String()
		{
			string input = string.Empty;
			int expected = 0;

			int result = StringUtils.StrCount(input);

			Assert.AreEqual(expected, result);
		}
	}
}
