﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
	[TestClass]
	public class TestNextPalindrome
	{
		[TestMethod]
		public void Test__Three_Digits()
		{
			int input = 123;
			string expected = "321";

			string result = NextPalindrome(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Four_Digits()
		{
			int input = 1234;
			string expected = "error";

			string result = NextPalindrome(input);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Test__Single_Digit()
		{
			int input = 5;
			string expected = "error";

			string result = NextPalindrome(input);

			Assert.AreEqual(expected, result);
		}
	}
}
