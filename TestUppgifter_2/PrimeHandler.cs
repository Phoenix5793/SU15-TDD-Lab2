using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUppgifter_2
{
   public static class PrimeHandler
    {
       public static int[] NextPrime(int input)
       {
            int[] PrimeIntArray = new int[3];
            int count = 0;
            for (int i = input + 1; count < 3; i++)
            {
                if (i == 2)
                {
                    PrimeIntArray[count] = i;
                    count++;
                }

                if (i % 2 != 0)
                {
                    bool isPrime = true;
                    for (int j = 3; j * j <= i; j += 2)
                    {

                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime == true)
                    {
                        PrimeIntArray[count] = i;
                        count++;
                    }
                }
            }
            return PrimeIntArray;
        }
    }
}
