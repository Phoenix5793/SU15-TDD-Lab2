using System;
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
				return "string";
			}

			return "none";
		}

		public static string NextPalindrome(int input)
		{
			return string.Empty;
		}


		public static int[] NextPrime(int input)
		{
			return new int[] {};
		}

	}
}
