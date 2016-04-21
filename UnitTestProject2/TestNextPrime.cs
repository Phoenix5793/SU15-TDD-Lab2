using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
	[TestClass]
	public class TestNextPrime
	{
		[TestMethod]
		public void Test__Returns_3_Primes()
		{
			int input = 42;
			int expected = 3;

			int[] result = NextPrime(input);

			Assert.AreEqual(expected, result.Length);
		}

		[TestMethod]
		public void Test__Returns_Correct_Primes()
		{
			int input = 42;
			int[] expected = {43, 47, 53};

			int[] result = NextPrime(input);

			Assert.AreEqual(expected, result);
		}
	}
}
