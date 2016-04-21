using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUppgifter_2
{
    public static class Palindrome
    {
        public static string NextPal(int input)
        {
            int numberToReturn = 0;
            string inputToString = input.ToString();
            if (inputToString.Length < 3 || inputToString.Length > 3)
            {
                return "Error";
            }
            for (int i = input + 1; i <= 999; i++)
            {
                inputToString = i.ToString();
                char[] inputCharArray = inputToString.ToCharArray();
                Array.Reverse(inputCharArray);
                string reversedInput = new string(inputCharArray);
                if (reversedInput == inputToString)
                {
                    numberToReturn = i;
                    break;
                }
            }

            string correctString = numberToReturn.ToString();
            return correctString;
        }
    }
}
