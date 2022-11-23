using System;
using System.Collections.Generic;
using System.Text;

namespace Nov22_Fundamental
{
    class ReverseNumber
    {
		static public void Main()
		{
			int num = 4562;
			Console.Write("Reverse of no. is "
			+ reversDigits(num));
		}
		public static int length(int num)
		{
			// returns the length of a given number
			return (int)Math.Log10(num) + 1;
		}
		public static int rev_number(int num)
		{
			if ((num % 10) == num)
				return num;
			int last = num % 10;
			int remaining = num / 10;
			int l = length(remaining);
			return last * (int)Math.Pow(10, l)
			+ rev_number(remaining);
		}
		public void reverse()
        {
            int num=0,rev=0,r=1;
            Console.WriteLine("Enter Number");
            num= int.Parse(Console.ReadLine());

            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num/=10;
            }
            Console.WriteLine("Reverse=" + rev);
            }

		public static string ReverseString(string s)
		{
			char[] array = s.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}

		static int reversDigits(int num)
		{
			// converting number to string
			string strin = num.ToString();

			// reversing the string
			strin = ReverseString(strin);

			// converting string to integer
			num = int.Parse(strin);

			// returning integer
			return num;
		}
		public void test()
        {
			double a = 423;
			double b = 0;
			double c = -2.45;
			double nan = Double.NaN;
			double positiveInfinity = Double.PositiveInfinity;
			double negativeInfinity = Double.NegativeInfinity;

			// Input is positive number so output
			// will be logarithm of number
			Console.WriteLine(Math.Log10(a));

			// positive zero as argument, so output
			// will be -Infinity
			Console.WriteLine(Math.Log10(b));

			// Input is negative number so output
			// will be NaN
			Console.WriteLine(Math.Log10(c));

			// Input is NaN so output
			// will be NaN
			Console.WriteLine(Math.Log10(nan));

			// Input is PositiveInfinity so output
			// will be Infinity
			Console.WriteLine(Math.Log10(positiveInfinity));

			// Input is NegativeInfinity so output
			// will be NaN
			Console.WriteLine(Math.Log10(negativeInfinity));
		}
    }
}
