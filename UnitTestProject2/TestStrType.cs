using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUppgifter_2;

namespace UnitTestProject2
{
	[TestClass]
	public class TestStrType
	{
		[TestMethod]
		public void Test__Is_Number__Single_Digit()
		{
			string input = "1";
			string expected = "number";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Is_Number__Multiple_Digits()
		{
			string input = "457476";
			string expected = "number";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Is_String__Single_Word()
		{
			string input = "ghjgjhgjkgk";
			string expected = "word";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Is_None__Many_Words()
		{
			string input = "Apa blåbär cykelpump";
			string expected = "none";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Is_None__Mixed_Digits_Letters()
		{
			string input = "12141hlhbsg";
			string expected = "none";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Is_None__With_Digits__With_Special_Chars()
		{
			string input = "1234214%34241";
			string expected = "none";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Empty_String()
		{
			string input = string.Empty;
			string expected = "none";

			string result = StringUtils.StrType(input);

			Assert.AreEqual(expected, result);
		}
	}
}
