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

            string input = StrExaminer.Examin("Hejsan");

            Assert.AreEqual(result,input);
        }

        [TestMethod]
        public void StrType_AreNotEqual()
        {
            string result = "None";

            string input = StrExaminer.Examin("4539");

            Assert.AreNotEqual(result, input);
        }

        [TestMethod]
        public void StrType_AreEqual_2()
        {
            string result = "Number";

            string input = StrExaminer.Examin("4539");

            Assert.AreEqual(result, input);
        }

        [TestMethod]
        public void NextPalindrome_AreEqual()
        {
            //Expected Result
            string Expresult = "121";

            int nr = 120;

            string input = Palindrome.NextPal(nr);


            Assert.AreEqual(Expresult, input);
        }

        [TestMethod]
        public void NextPalindrome_AreNotEqual()
        {
            //Expected Result
            string Expresult = "121";

            int nr = 100;

            string input = Palindrome.NextPal(nr);


            Assert.AreNotEqual(Expresult, input);
        }

        [TestMethod]
        public void NextPrime_AreEqual()
        {
            int[] expResult = new int[]
            {
                5, 7, 11
            };

            int nr = 3;


            int[] input = PrimeHandler.NextPrime(nr);

            CollectionAssert.AreEqual(expResult, input);


        }

        [TestMethod]
        public void NextPrime_AreNotEqual()
        {
            int[] expResult = new int[]
            {
                5, 7, 11
            };

            int nr = 5;


            int[] input = PrimeHandler.NextPrime(nr);

            CollectionAssert.AreNotEqual(expResult, input);
        }

    }
}
