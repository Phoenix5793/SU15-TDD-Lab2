﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestUppgifter_2
{
	public static class StringUtils
	{
		public static int StrCount(string input)
		{
			return input.Length;
		}

		public static string StrType(string input)
		{
			if (Regex.IsMatch(input, $"^[0-9]+$"))
			{
				return "number";
			}

			if (Regex.IsMatch(input, $"^[a-zA-Z]+$"))
			{
				return "word";
			}

			return "none";
		}

		public static string NextPalindrome(int input)
		{
			return string.Empty;
		}


		public static int[] NextPrime(int input)
		{
			int[] primes = new int[3];
			int foundPrimes = 0;

			for (int i = 1; foundPrimes < 3; i++)
			{
				int candidate = input + i;
				if (IsPrime(candidate))
				{
					primes[foundPrimes] = candidate;
					i++;
					foundPrimes++;
				}
			}

			return primes;
		}

		public static bool IsPrime(int candidate)
		{
			int boundary = (int)Math.Sqrt(candidate);

			if (candidate == 1) return false;
			if (candidate == 2) return true;

			for (int i = 2; i <= boundary; i++)
			{
				if (candidate % i == 0) return false;
			}

			return true;
		}

	}
}
