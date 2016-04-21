using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUppgifter_2
{
   public static class StrExaminer
    {
       public static string Examin(string input)
       {
            string correctString = null;
            int containsNumber = 0;
            int containsLetter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    containsNumber++;
                }
                if (char.IsLetter(input[i]))
                {
                    containsLetter++;
                }

            }
            if (containsLetter > 0 && containsNumber > 0 || input == "")
            {
                correctString = "None";
            }
            else if (containsLetter == 0)
            {
                correctString = "Number";
            }
            else if (containsNumber == 0)
            {
                correctString = "Word";
            }
            return correctString;
        }
    }
}
