using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUppgifter_2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StrCount_AreEqual()
        {
            int result = 7;

            int input = StrCounter.Counter("metoden");


            Assert.AreEqual(result,input);
        }

        [TestMethod]
        public void StrCount_AreNotEqual()
        {
            int result = 7;

            int input = StrCounter.Counter("hejsan");


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
            int Expresult = 121;
           

            int input = Palindrome.NextPal();


            Assert.AreEqual(Expresult, input);
        }

        [TestMethod]
        public void NextPalindrome_AreNotEqual()
        {
            int Expresult = 121;


            int input = Palindrome.NextPal();


            Assert.AreEqual(Expresult, input);
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
