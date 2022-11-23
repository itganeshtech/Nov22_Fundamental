using System;
using System.Collections.Generic;
using System.Text;

namespace Nov22_Fundamental
{
    class TempTest
    {
        static void Test()
        {
            Console.WriteLine("Success");
        }
        static public void Main(string[] args)
        {
            //string s = "Testing";
            //char[] array = s.ToCharArray();
            //Console.WriteLine(array);
            //Array.Reverse(array);
            //Console.WriteLine(array);
            // IN CODE, decimal separator is always DOT regardless of computer
            //language settings
            //double piApproximately = 3.14;
            //// Pi is already available in C#
            //double piMorePrecisely = Math.PI;
            //// Decimal numbers have always limited precision
            //double notCompletelyOne = 0.999999999999999999;
            //Console.WriteLine("Pi value from our code: " + piApproximately);
            //Console.WriteLine("Pi value from C#: " + piMorePrecisely);
            //Console.WriteLine("This should not be exact one: " + notCompletelyOne);
            DateTime now = System.DateTime.Now;
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hours = now.Hour;
            int minutes = now.Minute;
            int seconds = now.Second;
            DateTime justDateWithoutTime = now.Date;
            Console.WriteLine(now);
            Console.WriteLine(now.Date);
            // Output
            Console.WriteLine("Day: " + day);
            Console.WriteLine("Month: " + month);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Minutes: " + minutes);
            Console.WriteLine("Seconds: " + seconds);
            Console.WriteLine("Date component: " + justDateWithoutTime);
            // Formatting output our way
            Console.WriteLine("Our output: " +
            year + ", " + month + "/" + day +
            " " +
            hours + " hours " + minutes + " minutes");
        }
    }
}
