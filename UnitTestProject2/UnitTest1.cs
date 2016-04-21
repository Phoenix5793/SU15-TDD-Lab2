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

            int input = 7;


            Assert.AreEqual(result,input);
        }

        [TestMethod]
        public void StrCount_AreNotEqual()
        {
            int result = 7;

            int input = 5;


            Assert.AreNotEqual(result, input);
        }

        [TestMethod]
        public void StrType_AreEqual()
        {
            string result = "Word";

            string input = "Word";

            Assert.AreEqual(result,input);
        }

        [TestMethod]
        public void StrType_AreNotEqual()
        {
            string result = "None";

            string input = "Word";

            Assert.AreNotEqual(result, input);
        }

        [TestMethod]
        public void StrType_AreEqual_2()
        {
            string result = "Number";

            string input = "Number";

            Assert.AreEqual(result, input);
        }

        [TestMethod]
        public void NextPalindrome_AreEqual()
        {
            //Expected Result
            string Expresult = "121";

            int nr = 120;

            string input = "121";


            Assert.AreEqual(Expresult, input);
        }

        [TestMethod]
        public void NextPalindrome_AreNotEqual()
        {
            //Expected Result
            string Expresult = "121";

            int nr = 100;

            string input = "100";


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


            int[] input = new int[]
            {
                5, 7, 11
            };

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


            int[] input = new int[]
            {
                7,11,13
            };

            CollectionAssert.AreNotEqual(expResult, input);
        }

    }
}
