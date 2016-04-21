using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StrCount_AreEqual()
        {
            int result = 7;

            int input = StrCounter.Counter();


            Assert.AreEqual(result,input);
        }

        [TestMethod]
        public void StrCount_AreNotEqual()
        {
            int result = 7;

            int input = StrCounter.Counter();


            Assert.AreNotEqual(result, input);
        }

        [TestMethod]
        public void StrType_AreEqual()
        {
            string result = "Word";

            string input = StrExaminer.Examin();

            Assert.AreEqual(result,input);
        }

        [TestMethod]
        public void StrType_AreNotEqual()
        {
            string result = "Word";

            string input = StrExaminer.Examin();

            Assert.AreNotEqual(result, input);
        }

        [TestMethod]
        public void NextPalindrome_AreEqual()
        {
            int result = 123;

            int input = Palindrome.NextPal();

            Assert.AreEqual(result, input);
        }

        [TestMethod]
        public void NextPalindrome_AreNotEqual()
        {
            int result = 123;

            int input = Palindrome.NextPal();

            Assert.AreNotEqual(result, input);
        }

        [TestMethod]
        public void NextPrime_AreEqual()
        {
            int[] ExpResult = new int[]
            {
                5, 7, 11
            };

            int[] Input = new int[3];

            Input = PrimeHandler.NextPrime();

            Assert.AreEqual(ExpResult,Input);


        }

        [TestMethod]
        public void NextPrime_AreNotEqual()
        {
            int[] ExpResult = new int[]
            {
                5, 7, 11
            };

            int[] Input = new int[];

            Input = PrimeHandler.NextPrime();

            Assert.AreNotEqual(ExpResult, Input);
        }

    }
}
