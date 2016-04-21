﻿using System;
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
            int[] result = new int[]
            {
                1, 2, 3
            };

            int[] input = new int[]
            {
                Palindrome.NextPal()
            }; 

            Assert.AreEqual(result, input);
        }

        [TestMethod]
        public void NextPalindrome_AreNotEqual()
        {
            int[] result = new int[]
            {
                1, 2, 3
            };

            int[] input = new int[]
            {
                Palindrome.NextPal()
            };

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

            int[] Input = new int[3];

            Input = PrimeHandler.NextPrime();

            Assert.AreNotEqual(ExpResult, Input);
        }

    }
}